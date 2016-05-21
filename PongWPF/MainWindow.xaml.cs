using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PongGame
{

    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _ball;
            RightPad.DataContext = _rightPad;
            LeftPad.DataContext = _leftPad;
            Ball.DataContext = _ball;
            label4.DataContext = _rightPad;

            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Start();
            timer.Tick += _timer_Tick;
        }

        private double _angle = 155;
        private double _speed = 5;
        private int _padSpeed = 9;

        void _timer_Tick(object sender, EventArgs e)
        {
            if ((Keyboard.IsKeyDown(Key.W)) && (_leftPad.YPosition > 0)) _leftPad.YPosition -= _padSpeed;
            if ((Keyboard.IsKeyDown(Key.S)) && (_leftPad.YPosition < MainCanvas.ActualHeight - LeftPad.ActualHeight)) _leftPad.YPosition += _padSpeed;
            if ((Keyboard.IsKeyDown(Key.Up)) && (_rightPad.YPosition > 0)) _rightPad.YPosition -= _padSpeed;
            if ((Keyboard.IsKeyDown(Key.Down)) && (_rightPad.YPosition < MainCanvas.ActualHeight - RightPad.ActualHeight)) _rightPad.YPosition += _padSpeed;


            if (_ball.Y <= 0) _angle = _angle + (180 - 2 * _angle);
            if (_ball.Y >= MainCanvas.ActualHeight - 20) _angle = _angle + (180 - 2 * _angle);

            if (CheckCollision() == true)
            {
                ChangeAngle();
                ChangeDirection();
            }
            double radians = (Math.PI / 180) * _angle;
            Vector vector = new Vector { X = Math.Sin(radians), Y = -Math.Cos(radians) };
            _ball.X += vector.X * _speed;
            _ball.Y += vector.Y * _speed;

            if (_ball.X >= 790)
            {
                _ball.LeftResult += 1;
                GameReset();
            }
            if (_ball.X <= 5)
            {
                _ball.RightResult += 1;
                GameReset();
            }
        }

        private void GameReset()
        {
            _ball.Y = 210;
            _ball.X = 380;
            _speed = 5;
        }

        private void ChangeAngle()
        {
            if (_ball.MovingRight == true) _angle = 270 - ((_ball.Y + 10) - (_rightPad.YPosition + RightPad.ActualHeight/2));
            else if (_ball.MovingRight == false) _angle = 90 + ((_ball.Y + 10) - (_leftPad.YPosition + LeftPad.ActualHeight/2));
        }

        private void ChangeDirection()
        {
            _ball.MovingRight = !_ball.MovingRight;
            _speed *= 1.05; //beállítási lehetőség - Nőjjön -e a sebesség?
        }

        private bool CheckCollision()
        {
            bool collisionResult = false;
            if (_ball.MovingRight == true)
                collisionResult = _ball.X >= 760 && (_ball.Y > _rightPad.YPosition - 20 && _ball.Y < _rightPad.YPosition + 80);

            if (_ball.MovingRight == false)
                collisionResult = _ball.X <= 20 && (_ball.Y > _leftPad.YPosition - 20 && _ball.Y < _leftPad.YPosition + 80);

            return collisionResult;
        }


        readonly Ball _ball = new Ball { X = 380, Y = 210, MovingRight = true };

        readonly Pad _leftPad = new Pad { YPosition = 90 };
        readonly Pad _rightPad = new Pad { YPosition = 90 };


        private void MainWindow_OnKeyDown(object sender, KeyboardEventArgs e)
        {
            //törölve
        }



    }
}
