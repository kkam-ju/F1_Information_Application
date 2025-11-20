using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            this.Load += Form11_Load;  // 폼 로드 이벤트 연결
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            listView1.Clear(); //컬럼을 초기화

            // 컬럼 추가
            listView1.Columns.Add("No", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("그랑프리", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("날짜", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("우승자", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("팀", 120, HorizontalAlignment.Left);
            

            // 데이터 추가
            string[,] raceResults = new string[,] // 각 배열의 원소를 구분하기 위해 ,사용 
            {
                { "1", "오스트레일리아 GP", "2025-03-16", "L.노리스", "맥라렌"},
                { "2", "중국 GP", "2025-03-23", "O.피아스트리", "맥라렌" },
                { "3", "일본 GP", "2025-04-06", "M.베르스타펜", "레드불" },
                { "4", "바레인 GP", "2025-04-14", "O.피라스트리", "맥라렌" },
                { "5", "사우디아라비아 GP", "2025-04-21", "O.피라스트리", "맥라렌" },
                { "6", "사우디아라비아 GP", "2025-04-21", "O.피라스트리", "맥라렌" },
                { "7", "마이애미 GP", "2025-05-05", "O.피라스트리", "맥라렌" },
                { "8", "에미리아 로마냐 GP", "2025-05-18", "M.베르스타펜", "레드불" },
                { "9", "모나코 GP", "2025-05-25", "L.노리스", "맥라렌" },
                { "10", "스페인 GP", "2025-06-01", "O.피아스트리", "맥라렌" },
                { "11", "캐나다 GP", "2025-06-16", "G.러셀", "메르세데스" },
                { "12", "오스트리아 GP", "2025-06-29", "L.노리스", "맥라렌" },
                { "13", "영국 GP", "2025-07-06", "L.노리스", "맥라렌" },
                { "14", "벨기에 GP", "2025-07-27", "O.피아스트리", "맥라렌" },
                { "15", "헝가리 GP", "2025-08-03", "", "" },
                { "16", "네덜란드 GP", "2025-08-31", "", "" },
                { "17", "이탈리아 GP", "2025-09-07", "", "" },
                { "18", "아제르바이잔 GP", "2025-09-21", "", "" },
                { "19", "싱가포르 GP", "2025-10-05", "", "" },
                { "20", "미국 GP", "2025-10-20", "", "" },
                { "21", "멕시코 GP", "2025-10-27", "", "" },
                { "22", "브라질 GP", "2025-11-10", "", "" },
                { "23", "라스베이거스 GP", "2025-11-23", "", "" },
                { "24", "카타르GP", "2025-12-01", "", "" },
                { "25", "아부다비 GP", "2025-12-07", "", "" },

            };

            // 반복을 활용해서 raceResult의 배열요소를 넣어주기 위함
            for (int i = 0; i < raceResults.GetLength(0); i++)
            {
                var item = new ListViewItem(raceResults[i, 0]);
                for (int j = 1; j < raceResults.GetLength(1); j++)
                {
                    item.SubItems.Add(raceResults[i, j]);
                }
                listView1.Items.Add(item);
            }
        }

        private void btn_Mclaren_Click(object sender, EventArgs e)
        {
            label1.Text = "이름 : 오스카 피아스트리";
            label2.Text = "국적 : 호주";
            label3.Text = "월드 챔피언십 횟수 : 0";

            label4.Text = "이름 : 랜도 노리스";
            label5.Text = "국적 : 영국";
            label6.Text = "월드 챔피언십 횟수 : 0";

            string driver1ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\피아스트리.jpg";
            string driver2ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\노리스.jpg";

            if (System.IO.File.Exists(driver1ImagePath))
            {
                pictureBox13.Image = Image.FromFile(driver1ImagePath);
            }


            if (System.IO.File.Exists(driver2ImagePath))
            {
                pictureBox14.Image = Image.FromFile(driver2ImagePath);
            }

        }

        private void btn_Ferrari_Click(object sender, EventArgs e)
        {
            label1.Text = "이름 : 찰스 르클레르";
            label2.Text = "국적 : 모나코";
            label3.Text = "월드 챔피언십 횟수 : 0";

            label4.Text = "이름 : 루이스 헤밀턴";
            label5.Text = "국적 : 영국";
            label6.Text = "월드 챔피언십 횟수 : 7";

            string driver1ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\르클레르.jpg";
            string driver2ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\헤밀턴.jpg";

            if (System.IO.File.Exists(driver1ImagePath))
            {
                pictureBox13.Image = Image.FromFile(driver1ImagePath);
            }


            if (System.IO.File.Exists(driver2ImagePath))
            {
                pictureBox14.Image = Image.FromFile(driver2ImagePath);
            }
        }

        private void btn_Mercedes_Click(object sender, EventArgs e)
        {
            label1.Text = "이름 : 조지 러셀";
            label2.Text = "국적 : 영국";
            label3.Text = "월드 챔피언십 횟수 : 0";

            label4.Text = "이름 : 키미 안토넬리";
            label5.Text = "국적 : 이탈리아";
            label6.Text = "월드 챔피언십 횟수 : 0";

            string driver1ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\러셀.jpg";
            string driver2ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\안토넬리.jpg";

            if (System.IO.File.Exists(driver1ImagePath))
            {
                pictureBox13.Image = Image.FromFile(driver1ImagePath);
            }


            if (System.IO.File.Exists(driver2ImagePath))
            {
                pictureBox14.Image = Image.FromFile(driver2ImagePath);
            }
        }

        private void btn_Aston_Click(object sender, EventArgs e)
        {
            label1.Text = "이름 : 랜스 스트롤";
            label2.Text = "국적 : 캐나다";
            label3.Text = "월드 챔피언십 횟수 : 0";

            label4.Text = "이름 : 페르난도 알론소";
            label5.Text = "국적 : 스페인";
            label6.Text = "월드 챔피언십 횟수 : 2";

            string driver1ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\스트롤.jpg";
            string driver2ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\알론소.jpg";

            if (System.IO.File.Exists(driver1ImagePath))
            {
                pictureBox13.Image = Image.FromFile(driver1ImagePath);
            }


            if (System.IO.File.Exists(driver2ImagePath))
            {
                pictureBox14.Image = Image.FromFile(driver2ImagePath);
            }
        }

        private void btn_Redbull_Click(object sender, EventArgs e)
        {
            label1.Text = "이름 : 막스 베르스타펜";
            label2.Text = "국적 : 네덜란드";
            label3.Text = "월드 챔피언십 횟수 : 4";

            label4.Text = "이름 : 유키 츠노다";
            label5.Text = "국적 : 일본";
            label6.Text = "월드 챔피언십 횟수 : 0";

            string driver1ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\베르스타펜.jpg";
            string driver2ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\유키.jpg";

            if (System.IO.File.Exists(driver1ImagePath))
            {
                pictureBox13.Image = Image.FromFile(driver1ImagePath);
            }


            if (System.IO.File.Exists(driver2ImagePath))
            {
                pictureBox14.Image = Image.FromFile(driver2ImagePath);
            }
        }

        private void btn_Alpine_Click(object sender, EventArgs e)
        {
            label1.Text = "이름 : 피에르 가슬리";
            label2.Text = "국적 : 프랑스";
            label3.Text = "월드 챔피언십 횟수 : 0";

            label4.Text = "이름 : 플랑코 콜라핀토";
            label5.Text = "국적 : 아르헨티나";
            label6.Text = "월드 챔피언십 횟수 : 0";

            string driver1ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\가슬리.jpg";
            string driver2ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\프란코.jpg";

            if (System.IO.File.Exists(driver1ImagePath))
            {
                pictureBox13.Image = Image.FromFile(driver1ImagePath);
            }


            if (System.IO.File.Exists(driver2ImagePath))
            {
                pictureBox14.Image = Image.FromFile(driver2ImagePath);
            }
        }

        private void btn_Williams_Click(object sender, EventArgs e)
        {
            label1.Text = "이름 : 알렉산더 알본";
            label2.Text = "국적 : 태국";
            label3.Text = "월드 챔피언십 횟수 : 0";

            label4.Text = "이름 : 카를로스 사인츠";
            label5.Text = "국적 : 스페인";
            label6.Text = "월드 챔피언십 횟수 : 0";

            string driver1ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\알본.jpg";
            string driver2ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\사인츠.jpg";

            if (System.IO.File.Exists(driver1ImagePath))
            {
                pictureBox13.Image = Image.FromFile(driver1ImagePath);
            }


            if (System.IO.File.Exists(driver2ImagePath))
            {
                pictureBox14.Image = Image.FromFile(driver2ImagePath);
            }
        }

        private void btn_Sauber_Click(object sender, EventArgs e)
        {
            label1.Text = "이름 : 니코 휠켄버그";
            label2.Text = "국적 : 독일";
            label3.Text = "월드 챔피언십 횟수 : 0";

            label4.Text = "이름 : 가브리엘 보르톨레토";
            label5.Text = "국적 : 브라질";
            label6.Text = "월드 챔피언십 횟수 : 7";

            string driver1ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\휠켄버그.jpg";
            string driver2ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\가브리엘.jpg";

            if (System.IO.File.Exists(driver1ImagePath))
            {
                pictureBox13.Image = Image.FromFile(driver1ImagePath);
            }


            if (System.IO.File.Exists(driver2ImagePath))
            {
                pictureBox14.Image = Image.FromFile(driver2ImagePath);
            }
        }

        private void btn_Haas_Click(object sender, EventArgs e)
        {
            label1.Text = "이름 : 에스테반 오콘";
            label2.Text = "국적 : 프랑스";
            label3.Text = "월드 챔피언십 횟수 : 0";

            label4.Text = "이름 : 올리브 베어멘";
            label5.Text = "국적 : 영국";
            label6.Text = "월드 챔피언십 횟수 : 0";

            string driver1ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\오콘.jpg";
            string driver2ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\베어맨.jpg";

            if (System.IO.File.Exists(driver1ImagePath))
            {
                pictureBox13.Image = Image.FromFile(driver1ImagePath);
            }


            if (System.IO.File.Exists(driver2ImagePath))
            {
                pictureBox14.Image = Image.FromFile(driver2ImagePath);
            }
        }

        private void btn_Bulls_Click(object sender, EventArgs e)
        {
            label1.Text = "이름 : 리암 로슨";
            label2.Text = "국적 : 뉴질랜드";
            label3.Text = "월드 챔피언십 횟수 : 0";

            label4.Text = "이름 : 이삭 하자르";
            label5.Text = "국적 : 프랑스";
            label6.Text = "월드 챔피언십 횟수 : 0";

            string driver1ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\로슨.jpg";
            string driver2ImagePath = @"C:\김주엽\C# 개인 프로젝트 (F1)\드라이버 사진\하자르.jpg";

            if (System.IO.File.Exists(driver1ImagePath))
            {
                pictureBox13.Image = Image.FromFile(driver1ImagePath);
            }


            if (System.IO.File.Exists(driver2ImagePath))
            {
                pictureBox14.Image = Image.FromFile(driver2ImagePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Close(); 
        }
    }
}


