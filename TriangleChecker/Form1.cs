namespace TriangleChecker
{
    public partial class Checker : Form
    {
        public Checker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            double firstSideSize, secondSideSize, thirdSideSize;
            if (double.TryParse(SideA.Text, out firstSideSize) && double.TryParse(SideB.Text, out secondSideSize)

            && double.TryParse(SideC.Text, out thirdSideSize))

            {

                if (firstSideSize > 0 && secondSideSize > 0 && thirdSideSize > 0)

                {

                    if (firstSideSize == secondSideSize && secondSideSize == thirdSideSize)

                        result.Text = "Это равносторонний треугольник";

                    else if (firstSideSize + secondSideSize < thirdSideSize)

                        result.Text = "Такого треугольника не существует";

                    else if (firstSideSize + thirdSideSize < secondSideSize)

                        result.Text = "Такого треугольника не существует";

                    else if (thirdSideSize + secondSideSize < firstSideSize)

                        result.Text = "Такого треугольника не существует";

                    else if (firstSideSize == secondSideSize || firstSideSize == thirdSideSize || secondSideSize == thirdSideSize)

                        result.Text = "Это равнобедренный треугольник";

                    else

                        result.Text = "Это разносторонний треугольник";

                }

                else

                {

                    result.Text = "Значение сторон должно быть больше нуля";

                }

            }

            else

            {

                result.Text = "Ошибка! Исправьте значение.";

            }


        }
    }
}
