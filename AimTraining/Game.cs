using System;
using System.Drawing;
using System.Windows.Forms;

namespace AimTraining
{
    public partial class Game : Form
    {
        private Bitmap _crosshairTexture = Resource.Crosshair;
        private Bitmap _targetTexture = Resource.BlackAim;

        private Point _targetPosition = new Point(450, 450);
        private Point _direction = Point.Empty;

        private bool _middleLevel => _score > 200 && _score < 900;
        private bool _hardLevel => _score > 900 && _score < 4000;
        private bool _superHardLevel => _score > 4000;
        private bool _isGameEnd => _score > 5000;

        private uint _score;

        public Game()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

            UpdateStyles();
            Cursor.Hide();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!_isGameEnd)
            {
                Graphics graphics = e.Graphics;

                _targetPosition.X += _direction.X * TargetSpeed();
                _targetPosition.Y += _direction.Y * TargetSpeed();

                if (_targetPosition.X < 0 || _targetPosition.X > 500)
                {
                    _direction.X *= -1;
                }

                if (_targetPosition.Y < 0 || _targetPosition.Y > 500)
                {
                    _direction.Y *= -1;
                }

                var localPosition = this.PointToClient(Cursor.Position);
                var crosshairRectangle = new Rectangle(localPosition.X - 10, localPosition.Y - 10, 20, 20);
                var targetRectangle = new Rectangle(_targetPosition.X, _targetPosition.Y, 50, 50);

                Point between = new Point(localPosition.X - _targetPosition.X, localPosition.Y - _targetPosition.Y);
                float distance = (float)Math.Sqrt((between.X * between.X) + (between.Y * between.Y));

                if (distance < 50)
                {
                    AddScore(5);
                }
                else
                {
                    if (_score > 0)
                    {
                        RemoveScore(1);
                    }
                }

                graphics.DrawImage(_targetTexture, targetRectangle);
                graphics.DrawImage(_crosshairTexture, crosshairRectangle);
            }
            else
            {
                Mode.Text = "GAME END U HAVE OVER 5000 POINTS!";
            }
        }

        private void AddScore(uint score)
        {
            _score += score;
            UserScoreLabel.Text = _score.ToString();
        }

        private void RemoveScore(uint score)
        {
            _score -= score;
            UserScoreLabel.Text = _score.ToString();
        }

        private int TargetSpeed()
        {
            if (_middleLevel)
            {
                Mode.Text = "Middle Level";
                return 9;
            }
            else if (_hardLevel)
            {
                Mode.Text = "Hard Level";
                return 12;
            }
            else if (_superHardLevel)
            {
                Mode.Text = "Super-Hard Level";
                return 20;
            }

            Mode.Text = "Easy Level";
            return 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_isGameEnd) Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            timer2.Interval = random.Next(100, 1000);

            _direction.X = random.Next(-1, 2);
            _direction.Y = random.Next(-1, 2);
        }
    }
}
