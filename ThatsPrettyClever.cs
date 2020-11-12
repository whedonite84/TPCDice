// Icons made by <a href="https://www.flaticon.com/authors/freepik" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>

using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private bool _firstRollSinceReset;

        private int _rollNum;
        private DiceCollection _diceCap;

        private Players _players;

        private Game CurrGame = Game.ThatsPrettyClever;
        private enum Game
        {
            ThatsPrettyClever,
            TwiceAsClever,
            CleverCubed
        }

        private int RollNum
        {
            get => _rollNum;
            set
            {
                _rollNum = Math.Min(value, 3);
                string playersRoll = _players.Current == null ? "Roll" :
                    _players.Current.EndsWith("s") ? $"{_players.Current}' roll" :
                    $"{_players.Current}'s roll";

                lblRollNum.Text = $"{playersRoll} #{RollNum} of 3";
            }
        }

        public ThatsPrettyClever()
        {
            InitializeComponent();

            Redraw();

            _dice = DiceCollection.Load(this, _rng);
            _players = new Players(this);

            RollNum = 1;
        }

        private void Redraw()
        {
            txtYellow.BackColor = Color.Yellow;
            txtBlue.BackColor = Color.CornflowerBlue;
            txtWhite.BackColor = Color.White;

            switch (CurrGame)
            {
                case Game.ThatsPrettyClever:
                    Text = "Ganz Schön Clever!";
                    txtGreen.BackColor = Color.Green;
                    txtOrange.BackColor = Color.Orange;
                    txtPurple.BackColor = Color.DarkOrchid;
                    break;
                case Game.TwiceAsClever:
                    Text = "Doppelt So Clever!";
                    txtGreen.BackColor = Color.Green;
                    txtOrange.BackColor = Color.Gray;
                    txtPurple.BackColor = Color.HotPink;
                    break;
                case Game.CleverCubed:
                    Text = "Clever Hoch Drei!";
                    txtGreen.BackColor = Color.Turquoise;
                    txtOrange.BackColor = Color.Chocolate;
                    txtPurple.BackColor = Color.HotPink;
                    break;
            }

            BtnDieBack.Visible = CurrGame == Game.TwiceAsClever;
        }

        private void BtnScore_Click(object sender, EventArgs e)
        {
            if (_mostRecentlyHeld != null && _dice.HoldCount >= RollNum) _dice.Place(_mostRecentlyHeld);
            Refresh();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (_firstRollSinceReset)
            {
                _players.Next();
                _firstRollSinceReset = false;
            }

            RollNum = _dice.HoldCount + 1;
            Refresh();
            _dice.Roll();
        }

        private void txtDie_Click(object sender, EventArgs e)
        {
            var die = _dice[(TextBox)sender];

            die.Held = !die.Held;
            if (die.Held) _mostRecentlyHeld = die;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _dice.Reset();
            _mostRecentlyHeld = null;
            RollNum = 1;
            _firstRollSinceReset = true;
        }

        /// <summary>
        /// idkwtf
        /// </summary>
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

        private void RbTPC_CheckedChanged(object sender, EventArgs e)
        {
            ChangeGame(Game.ThatsPrettyClever);
        }

        private void RbTwice_CheckedChanged(object sender, EventArgs e)
        {
            ChangeGame(Game.TwiceAsClever);
        }

        private void RbCleverCubed_CheckedChanged(object sender, EventArgs e)
        {
            ChangeGame(Game.CleverCubed);
        }

        private void ChangeGame(Game game)
        {
            CurrGame = game;
            Redraw();
        }

        private void BtnDieBack_Click(object sender, EventArgs e)
        {
            foreach (var d in _dice.Where(d => d.Held && d.OnPlatter)) d.Reset();
        }

        private void PicPlayerLock_Click(object sender, EventArgs e)
        {
            _players.Locked = !_players.Locked;
        }

        private void BtnThatsPrettyCleverScoresheet_Click(object sender, EventArgs e)
        {
            Process.Start(@"PDFs\ThatsPrettyClever Scoresheet.pdf");
        }

        private void BtnThatsPrettyCleverChallengeScoresheet_Click(object sender, EventArgs e)
        {
            Process.Start(@"PDFs\ThatsPrettyClever Challenge.pdf");
        }

        private void BtnTwiceAsCleveScoresheet_Click(object sender, EventArgs e)
        {
            Process.Start(@"PDFs\TwiceAsClever Scoresheet.pdf");
        }

        private void BtnCleverCubedScoresheet_Click(object sender, EventArgs e)
        {
            Process.Start(@"PDFs\CleverCubed Scoresheet.pdf");
        }

        private void BtnThatsPrettyCleverRules_Click(object sender, EventArgs e)
        {
            Process.Start(@"PDFs\ThatsPrettyClever Rules.pdf");
        }

        private void BtnTwiceAsCleverRules_Click(object sender, EventArgs e)
        {
            Process.Start(@"PDFs\TwiceAsClever Rules.pdf");
        }

        private void BtnCleverCubedRules_Click(object sender, EventArgs e)
        {
            Process.Start(@"PDFs\CleverCubed Rules (unofficial).pdf");
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

    public class Players
    {
        private DataGridView _grd;
        private PictureBox _lockIcon;
        public DataGridViewRow _selectedRow => _grd.SelectedRows.Count > 0 ? _grd.SelectedRows[0] : null;

        public string Current => (string)_selectedRow?.Cells["ColPlayer"].Value;

        private bool _locked;
        public bool Locked
        {
            get => _locked;
            set
            {
                _locked = value;
                _lockIcon.Image = _locked ? Resources.Lock : Resources.Unlock;
                _grd.Enabled = _grd.AllowUserToAddRows = !_locked;

                if (_locked && _grd.SelectedCells.Count > 0) _grd.SelectedCells[0].OwningRow.Selected = true;
            }
        }

        public Players (ThatsPrettyClever form)
        {
            _grd = form.GrdPlayers;
            _lockIcon = form.PicPlayerLock;
        }

        public void Next()
        {
            if (_selectedRow == null) return;

            int selectedIndex = _grd.Rows.IndexOf(_selectedRow);
            _selectedRow.Selected = false;
            selectedIndex++;
            int playerCount = _locked ? _grd.Rows.Count : _grd.Rows.Count - 1; // If editable, last row is always the "Phantom" row
            if (selectedIndex >= playerCount) selectedIndex = 0; 
            _grd.Rows[selectedIndex].Selected = true;

            _grd.Refresh();
        }
    }
}
