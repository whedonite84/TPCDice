using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using TPCDice.Properties;

namespace TPCDice
{
    public partial class ThatsPrettyClever : Form
    {
        private DiceCollection _dice;
        private readonly Random _rng = new Random();
        private Die _mostRecentlyHeld;

        private int _rollNum;
        private DiceCollection _diceCap;

        private int RollNum
        {
            get => _rollNum;
            set
            {
                _rollNum = Math.Min(value, 3);
                lblRollNum.Text = $"Roll #{RollNum} of 3";
            }
        }

        public ThatsPrettyClever()
        {
            InitializeComponent();

            txtYellow.BackColor = Color.Yellow;
            txtBlue.BackColor = Color.CornflowerBlue;
            txtGreen.BackColor = Color.Green;
            txtOrange.BackColor = Color.Orange;
            txtPurple.BackColor = Color.DarkOrchid;
            txtWhite.BackColor = Color.White;

            _dice = DiceCollection.Load(this, _rng);

            RollNum = 1;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (_mostRecentlyHeld != null && _dice.HoldCount >= RollNum) _dice.Place(_mostRecentlyHeld);

            RollNum = _dice.HoldCount + 1;

            Refresh();
            if (btnRoll.Text == "Roll") _dice.Roll();
        }

        private void txtDie_Click(object sender, EventArgs e)
        {
            var die = _dice[(TextBox)sender];

            if (!die.Held && RollNum <= _dice.HoldCount) return;

            die.Held = !die.Held;
            if (die.Held) _mostRecentlyHeld = die;

            btnRoll.Text = _dice.HoldCount == 3 ? "Score" : "Roll";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _dice.Reset();
            _mostRecentlyHeld = null;
            RollNum = 1;
            btnRoll.Text = "Roll";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Capture")
            {
                _diceCap = _dice;
                button1.Text = "Restore";
            }
            else
            {
                _dice = _diceCap;
                button1.Text = "Capture";
            }
        }
    }

    public class Die
    {
        public TextBox Txt;
        public int Value => int.Parse(Txt.Text);

        public bool Held
        {
            get => Txt.ForeColor == Color.Red;
            set
            {
                if (Held == value) return;
                Txt.ForeColor = value ? Color.Red : Color.Black;
                Txt.Font = new Font(Txt.Font, value ? FontStyle.Strikeout : FontStyle.Regular);
            }
        }

        private readonly Random _rng;
        private int _platterOffset = 230;

        public bool OnPlatter
        {
            get => Txt.Location.Y >= _platterOffset;
            set
            {
                if (OnPlatter == value) return;
                int offset = value ? _platterOffset : -_platterOffset;
                Txt.Location = new Point(Txt.Location.X, Txt.Location.Y + offset);
            }
        }

        public Die(TextBox txt, Random rng)
        {
            Txt = txt;
            _rng = rng;
        }

        public void Roll()
        {
            Txt.Text = _rng.Next(1, 7).ToString();
            Txt.Refresh();
        }

        public void MoveToPlatter()
        {
            Txt.Location = new Point(Txt.Location.X, Txt.Location.Y + 207);
        }

        public void Reset()
        {
            Held = OnPlatter = false;
        }
    }

    public class DiceCollection : List<Die>
    {
        public Die Yellow;
        public Die Blue;
        public Die Green;
        public Die Orange;
        public Die Purple;
        public Die White;

        public DiceCollection(ThatsPrettyClever form, Random rng)
        {
            Yellow = new Die(form.txtYellow, rng);
            Blue = new Die(form.txtBlue, rng);
            Green = new Die(form.txtGreen, rng);
            Orange = new Die(form.txtOrange, rng);
            Purple = new Die(form.txtPurple, rng);
            White = new Die(form.txtWhite, rng);
        }

        public int HoldCount => this.Count(d => d.Held);

        public static DiceCollection Load(ThatsPrettyClever form, Random rng)
        {
            var retVal = new DiceCollection(form, rng);
            retVal.AddRange(new List<Die> {retVal.Yellow, retVal.Blue, retVal.Green, retVal.Orange, retVal.Purple, retVal.White});
            return retVal;
        }

        public Die this[TextBox key] => Find(d => d.Txt == key);

        public void Roll()
        {
            new SoundPlayer(Resources.RollSound).Play();

            for (int i = 0; i < 150; i++)
            {
                foreach (var d in this.Where(d => !d.Held && !d.OnPlatter)) d.Roll();
                Thread.Sleep(10);
            }
        }

        public void Reset()
        {
            foreach (var d in this) d.Reset();
        }

        public void Place(Die die)
        {
            int upperBound = this.Count(d => d.Held) < 3 ? die.Value : 7;
            foreach (var d in this.Where(d => !d.Held && d.Value < upperBound)) d.OnPlatter = true;
        }
    }
}
