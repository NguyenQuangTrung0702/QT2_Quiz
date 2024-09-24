using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class Form1 : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;
        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;


            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("Quiz Ended" + Environment.NewLine +
                                "You have answered " + score + " questions correcly" + Environment.NewLine +
                                "Your total percentage is " + percentage + " %" + Environment.NewLine +
                                "Click Ok to play again"

                    );

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {

                case 1:

                    pictureBox1.Image = Properties.Resources.image1;
                    lblQuestion.Text = "Ca sĩ nào đẹp trai nhất Việt Nam?";

                    lbl1.Text = "Sơn Tùng MT-P";
                    lbl2.Text = "Jack";
                    lbl3.Text = "J97";
                    lbl4.Text = "Trịnh Trần Phương Tuấn";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.image1;
                    lblQuestion.Text = "Trường đại học nào số 1 Việt Nam?";

                    lbl1.Text = "Ton Duc Thang University";
                    lbl2.Text = "RMIT";
                    lbl3.Text = "Đại học quốc gia";
                    lbl4.Text = "UIT";

                    correctAnswer = 2;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.image1;

                    lblQuestion.Text = "Ai là GOAT của bóng đá?";

                    lbl1.Text = "Ronaldo";
                    lbl2.Text = "Anh 7";
                    lbl3.Text = "Péle";
                    lbl4.Text = "Messi";

                    correctAnswer = 4;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.image1;

                    lblQuestion.Text = "Thủ đô của nước Anh?";

                    lbl1.Text = "Birmingham";
                    lbl2.Text = "London";
                    lbl3.Text = "Brighton";
                    lbl4.Text = "Liverpool";

                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.image1;

                    lblQuestion.Text = "Con gà có mấy cái đùi?";

                    lbl1.Text = "2";
                    lbl2.Text = "4";
                    lbl3.Text = "6";
                    lbl4.Text = "8";

                    correctAnswer = 1;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.image1;

                    lblQuestion.Text = "Bài hát là nhạc phim của Phim Mai?";

                    lbl1.Text = "Sau lời từ khước";
                    lbl2.Text = "Lara Craft";
                    lbl3.Text = "Master Cheif";
                    lbl4.Text = "Drake";

                    correctAnswer = 3;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.image1;

                    lblQuestion.Text = "Gió ơi xin đừng lấy em đi...";

                    lbl1.Text = "Hãy mang anh về chốn xuân thì";
                    lbl2.Text = "Call of Duty";
                    lbl3.Text = "Battlefield";
                    lbl4.Text = "Half Life 3";

                    correctAnswer = 1;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.image1;

                    lblQuestion.Text = "Ò?";

                    lbl1.Text = "Victoria";
                    lbl2.Text = "Donuts";
                    lbl3.Text = "Ciri";
                    lbl4.Text = "Yennefer";

                    correctAnswer = 3;

                    break;
            }




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private int currentQuestion = 1;
        private int timeLeft = 15;
        private void button1_Click(object sender, EventArgs e)
        {
            //currentQuestion++;
            //if (currentQuestion == 8)
            //{
            //    DialogResult result = MessageBox.Show(
            //        "Đã kết thúc phần bài làm",
            //        "End Quizz",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Exclamation
            //        );
            //} 
            //askQuestion(currentQuestion);
            questionTimer.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = timeLeft.ToString();
            if (timeLeft == 0)
            {
                currentQuestion++;
                if (currentQuestion == 8)
                {
                    DialogResult result = MessageBox.Show(
                        "Đã kết thúc phần bài làm",
                        "End Quizz",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                        );
                }
                askQuestion(currentQuestion);
                timeLeft = 15;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đặt khoảng thời gian của timer là 15 giây (15000 milliseconds)
            questionTimer.Interval = 1000;

            // Bắt đầu timer
            questionTimer.Start();

            // Hiển thị câu hỏi đầu tiên khi form được load
            askQuestion(currentQuestion);

            timeLeft = 15;
            lblTimer.Text = timeLeft.ToString();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            questionTimer.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát?",
                "Cảnh báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation
                );
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

    }
}
