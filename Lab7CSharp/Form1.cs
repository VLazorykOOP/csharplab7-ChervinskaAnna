using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<Figure> figures = new List<Figure>(); // Оголошення списку для зберігання фігур

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Можливо, ініціалізувати об'єкти малюнка тут
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Код для малювання об'єктів на PictureBox
            Graphics g = pictureBox1.CreateGraphics();
            // Цикл для малювання об'єктів з масиву
            foreach (Figure figure in figures)
            {
                figure.Draw(g);
            }
            g.Dispose();
        }

        // Код для додавання нового об'єкта до масиву
        private void btnAddObject_Click(object sender, EventArgs e)
        {
            // Отримати дані про об'єкт з полів форми та створити об'єкт
            // Додати створений об'єкт до списку фігур
        }

        // Код для переміщення об'єкту за допомогою кнопки
        private void btnMove_Click(object sender, EventArgs e)
        {
            // Викликати метод переміщення об'єкту з масиву
        }
    }

    // Класи для фігур
    public abstract class Figure
    {
        protected int x, y; // Координати фігури
        protected Color color; // Колір фігури

        public abstract void Draw(Graphics g); // Метод малювання

        public virtual void Move(int dx, int dy) // Метод переміщення
        {
            x += dx;
            y += dy;
        }
    }

    // Класи конкретних фігур
    public class Square : Figure
    {
        public override void Draw(Graphics g)
        {
            // Реалізація малювання квадрата
        }
    }

    public class MyRectangle : Figure // Змінив назву класу Rectangle на MyRectangle, щоб уникнути конфлікту з іншим класом з такою ж назвою
    {
        public override void Draw(Graphics g)
        {
            // Реалізація малювання прямокутника
        }
    }

    public class Ellipse : Figure
    {
        public override void Draw(Graphics g)
        {
            // Реалізація малювання еліпса
        }
    }

    public class Rhombus : Figure
    {
        public override void Draw(Graphics g)
        {
            // Реалізація малювання ромба
        }
    }
}
