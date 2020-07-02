using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] GuShi_Name = {
        "泊船瓜洲 (宋) 王安石",
        "秋思 (唐) 张籍",
        "望洞庭 (唐) 刘禹锡",
        "题西林壁 (宋) 苏轼",
        "牧童 (唐) 吕岩",
        "四时田园杂兴 (宋) 范成大",
        "乡村四月 (宋) 翁卷",
        "竹石 (清) 郑燮",
        "浪淘沙 (唐) 刘禹锡",
        "独坐敬亭山 (唐) 李白",
        "西江月·夜行黄沙道中 (宋) 辛弃疾"};
        String[] GuShi = {

            "京口瓜洲一水间，钟山只隔数重山。春风又绿江南岸，明月何时照我还？",
            "洛阳城里见秋风，欲作家书意万重。复恐匆匆说不尽，行人临发又开封。",
            "湖光秋月两相和，潭面无风镜未磨。遥望洞庭山水翠，白银盘里一青螺。",
            "横看成岭侧成峰，远近高低各不同。不识庐山真面目，只缘身在此山中。",
            "草铺横野六七里，笛弄晚风三四声。归来饱饭黄昏后，不脱蓑衣卧月明。",
            "昼出耘田夜绩麻，村庄儿女各当家。童孙未解供耕织，也傍桑阴学种瓜。",
            "绿遍山原白满川，子规声里雨如烟。乡村四月闲人少，才了蚕桑又插田。",
            "咬定青山不放松，立根原在破岩中。千磨万击还坚劲，任尔东西南北风。",
            "九曲黄河万里沙，浪淘风簸自天涯。如今直上银河去，同到牵牛织女家。",
            "众鸟高飞尽，孤云独去闲。相看两不厌，只有敬亭山。",
            "明月别枝惊鹊，清风半夜鸣蝉。稻花香里说丰年，听取蛙声一片。七八个星天外，两三点雨山前。旧时茅店社林边，路转溪桥忽见。"};
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.User_Text.Text == GuShi[Convert.ToInt32(this.GuShi_XLH.Text)])
                {
                    this.FanKuiZhi.Text = "你答对了！";
                }
                else
                {
                    this.FanKuiZhi.Text = "你默写错了！请重新默写！";
                    MessageBox.Show("你默写错了!请重新默写！", "默写结果", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                this.label1.Text = ("古诗库暂时还没有录入这首古诗，你可以选择手动录入！");
            }
        }

        private void s_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToString(GuShi_XLH.Text).Length != 0)
                {
                    this.label1.Text = "请默写古诗:《" + GuShi_Name[Convert.ToInt32(this.GuShi_XLH.Text)] + "》";
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                this.label1.Text = ("古诗库暂时还没有添加这首古诗！您可以手动添加!");
            }
        }

        private void LuRuGuShi_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(this.textBox1.Text).Length == 0 || Convert.ToString(this.textBox2.Text).Length==0)
            {
                MessageBox.Show("请输入古诗的标题或者内容！", "系统错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Text = string.Empty;
                this.textBox2.Text = string.Empty;
                this.JieGuo_LuRu.Text = string.Empty;
                return;
            }
            string GuShi_Name_User = this.textBox1.Text;
            string GuShi_NeiRong_User = this.textBox2.Text;
            File.AppendAllText("扩展古诗内容.txt",GuShi_NeiRong_User);
            File.AppendAllText("扩展古诗名字.txt", GuShi_Name_User);
            this.JieGuo_LuRu.Text = "录入成功!";
        }

        private void ZhiLing_Click(object sender, EventArgs e)
        { 
            string[] ZhiLingKu = {"生成字节码","查询古诗"};
            if (this.ZhiLing_user.Text.Length==0)
            {
                MessageBox.Show("请输入指令再运行！");
                return;
            }
            string ZhiLing = this.ZhiLing_user.Text;
            if (ZhiLing == "生成字节码")
            {
                if (Convert.ToString(this.textBox1.Text).Length == 0 || Convert.ToString(this.textBox2.Text).Length == 0)
                {
                    MessageBox.Show("请输入古诗的标题或者内容！", "系统错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox1.Text = string.Empty;
                    this.textBox2.Text = string.Empty;
                    this.JieGuo_LuRu.Text = string.Empty;
                    return;
                }
                string GuShi_Name_User = this.textBox1.Text;
                string GuShi_NeiRong_User = this.textBox2.Text;
                File.AppendAllText("字节码古诗内容.txt", '"'+GuShi_NeiRong_User+'"'+',');
                File.AppendAllText("字节码古诗名字.txt",'"'+ GuShi_Name_User+'"'+',');
                this.JieGuo_LuRu.Text = "代码:'生成字节码'——运行成功！";
            }
            else if (ZhiLing.Contains("查询古诗")) {
                ZhiLing = ZhiLing.Replace("查询古诗:", "");
                int ChaXunShuZhi = int.Parse(ZhiLing);
                this.JieGuo_LuRu.Text = GuShi_Name[ChaXunShuZhi]+"          "+GuShi[ChaXunShuZhi];
                GC.Collect(ChaXunShuZhi);
            }
            else
            {
                this.JieGuo_LuRu.Text = "代码:"+ZhiLing+"——运行失败:"+"代码库暂时没有这个指令!";
                this.ZhiLing_user.Text = "代码库:"+string.Join(",  ",ZhiLingKu);
            }
        }
    }
}
