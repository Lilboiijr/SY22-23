using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace my_game
{
    internal class player
    {
        public int m_health;
        public PictureBox m_picture;
        public Point m_location;
        public int m_speed = 5;
        public int m_X = 0;
        public int m_Y = 0;
        public Form1 m_parent;
        public player(PictureBox picture, Form1 parent)
        {
            m_picture = picture;
            m_location= picture.Location;
            m_parent = parent;
        }
        public player(PictureBox picture, Form1 parent, int X, int Y, int speed): this(picture, parent)
        {
            m_X = X; 
            m_Y = Y;
            m_speed = speed;
        }
        public void tick()
        {
            move();
        }
        public void move()
        {
            if (!m_parent.isClear(m_picture, m_speed * m_X, m_speed * m_Y))
            {
                m_X *= -1;
                m_Y *= -1;
                return;
            }
            m_location = new Point(m_location.X + m_speed * m_X, m_location.Y + m_speed * m_Y);
            m_picture.Location = m_location;
        }
        public void moveleft()
        {
            if (!m_parent.isClear(m_picture, -m_speed, 0))
                return;
            m_location = new Point(m_location.X - m_speed, m_location.Y);
            m_picture.Location= m_location;
        }
        public void moveright()
        {
            if (!m_parent.isClear(m_picture, +m_speed, 0))
                return;
            m_location = new Point(m_location.X + m_speed, m_location.Y);
            m_picture.Location = m_location;
        }
        public void moveup()
        {
            if (!m_parent.isClear(m_picture, 0, - m_speed))
                return;
            m_location = new Point(m_location.X, m_location.Y - m_speed);
            m_picture.Location = m_location;
        }
        public void movedown()
        {
            if (!m_parent.isClear(m_picture, 0, +m_speed))
                return;
            m_location = new Point(m_location.X, m_location.Y + m_speed);
            m_picture.Location = m_location;
        }
    }
}
