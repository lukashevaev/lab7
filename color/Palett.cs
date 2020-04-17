using System;
using System.Drawing;
using System.Windows.Forms;

namespace Color
{
    public partial class Palett : Form
    {
        public Palett()
        {
            InitializeComponent();
            NewColor();
        }

        private void NewColor()
        {
            /// ColorPanel.BackColor = Color.FromArgb()
            /// Создает структуру Color из указанных 8-разрядных значений компонентов ARGB (альфа, красный, зеленый и синий)
            ColorPanel.BackColor = System.Drawing.Color.FromArgb(tb_red.Value, tb_green.Value, tb_blue.Value);
            ///удаляем данные из буфера обмена
            Clipboard.Clear();
            ///Для записи строки в буфер обмена следует вызвать метод SetText(). 
            Clipboard.SetText($"#{tb_red.Value:X}{tb_green.Value:X}{tb_blue.Value:X}");
            ///всплывающее окно с назначением эл-та управления
            toolTip.SetToolTip(ColorPanel, Clipboard.GetText());
        }

        private void color_scroll(object sender, EventArgs e)
        {
            NewColor();
        }
    }
}
