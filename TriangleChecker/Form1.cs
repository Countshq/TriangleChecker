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

                        result.Text = "��� �������������� �����������";

                    else if (firstSideSize + secondSideSize < thirdSideSize)

                        result.Text = "������ ������������ �� ����������";

                    else if (firstSideSize + thirdSideSize < secondSideSize)

                        result.Text = "������ ������������ �� ����������";

                    else if (thirdSideSize + secondSideSize < firstSideSize)

                        result.Text = "������ ������������ �� ����������";

                    else if (firstSideSize == secondSideSize || firstSideSize == thirdSideSize || secondSideSize == thirdSideSize)

                        result.Text = "��� �������������� �����������";

                    else

                        result.Text = "��� �������������� �����������";

                }

                else

                {

                    result.Text = "�������� ������ ������ ���� ������ ����";

                }

            }

            else

            {

                result.Text = "������! ��������� ��������.";

            }


        }
    }
}
