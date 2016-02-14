using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;

namespace Test
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            f_saveReadFirst(false);
            f_reStyle();
        }
        private Color[] m_colors;
        private float m_fstyle;
        private int[] m_istyle;
        /// <summary>
        /// 获取初始的波形显示控件的样式或设置为初始样式
        /// </summary>
        /// <param name="isRead">获取ture | 设置false</param>
        private void f_saveReadFirst(bool isRead)
        {
            if (!isRead)
            {
                m_colors = new Color[18];
                m_istyle = new int[2];
                m_istyle[0] = zGraphTest.m_titleSize;
                m_fstyle = zGraphTest.m_titlePosition;
                m_colors[0] = zGraphTest.m_titleColor;
                m_colors[1] = zGraphTest.m_titleBorderColor;
                m_colors[2] = zGraphTest.m_backColorL;
                m_colors[3] = zGraphTest.m_backColorH;
                m_colors[4] = zGraphTest.m_coordinateLineColor;
                m_colors[5] = zGraphTest.m_coordinateStringColor;
                m_colors[6] = zGraphTest.m_coordinateStringTitleColor;
                m_istyle[1] = zGraphTest.m_iLineShowColorAlpha;
                m_colors[7] = zGraphTest.m_iLineShowColor;
                m_colors[8] = zGraphTest.m_GraphBackColor;
                m_colors[9] = zGraphTest.m_ControlItemBackColor;
                m_colors[10] = zGraphTest.m_ControlButtonBackColor;
                m_colors[11] = zGraphTest.m_ControlButtonForeColorL;
                m_colors[12] = zGraphTest.m_ControlButtonForeColorH;
                m_colors[13] = zGraphTest.m_DirectionBackColor;
                m_colors[14] = zGraphTest.m_DirectionForeColor;
                m_colors[15] = zGraphTest.m_BigXYBackColor;
                m_colors[16] = zGraphTest.m_BigXYButtonBackColor;
                m_colors[17] = zGraphTest.m_BigXYButtonForeColor;      
            }
            else
            {
                //样式
                textBox标题字体大小.Text = m_istyle[0].ToString();
                zGraphTest.m_titleSize = m_istyle[0];
                textBox标题位置.Text = m_fstyle.ToString();
                zGraphTest.m_titlePosition = m_fstyle;
                zGraphTest.m_titleColor=button标题颜色.BackColor = m_colors[0];
                zGraphTest.m_titleBorderColor=button标题描边颜色.BackColor = m_colors[1];
                zGraphTest.m_backColorL=button背景色渐进起始颜色.BackColor = m_colors[2];
                zGraphTest.m_backColorH=button背景色渐进终止颜色.BackColor = m_colors[3];
                zGraphTest.m_coordinateLineColor=button坐标线颜色.BackColor = m_colors[4];
                zGraphTest.m_coordinateStringColor=button坐标值颜色.BackColor = m_colors[5];
                zGraphTest.m_coordinateStringTitleColor=button坐标标题颜色.BackColor = m_colors[6];
                textBox网络线的透明度.Text = m_istyle[1].ToString();
                zGraphTest.m_iLineShowColorAlpha = m_istyle[1];
                zGraphTest.m_iLineShowColor=button网络线的颜色.BackColor = m_colors[7];
                zGraphTest.m_GraphBackColor=button波形显示区域背景色.BackColor = m_colors[8];
                zGraphTest.m_ControlItemBackColor=button工具栏背景色.BackColor = m_colors[9];
                zGraphTest.m_ControlButtonBackColor=button工具栏按钮背景色.BackColor = m_colors[10];
                zGraphTest.m_ControlButtonForeColorL=button工具栏按钮前景选中颜色.BackColor = m_colors[11];
                zGraphTest.m_ControlButtonForeColorH=button工具栏按钮前景未选中颜色.BackColor = m_colors[12];
                zGraphTest.m_DirectionBackColor=button标签说明框背景颜色.BackColor = m_colors[13];
                zGraphTest.m_DirectionForeColor=button标签说明框文字颜色.BackColor = m_colors[14];
                zGraphTest.m_BigXYBackColor=button放大选取框背景颜色.BackColor = m_colors[15];
                zGraphTest.m_BigXYButtonBackColor=button放大选取框按钮背景颜色.BackColor = m_colors[16];
                zGraphTest.m_BigXYButtonForeColor=button放大选取框按钮文字颜色.BackColor = m_colors[17];
                
            }
        }
        /// <summary>
        /// 获取波形显示控件基本属性和样式，并更新到该程序界面
        /// </summary>
        private void f_reStyle()
        {
            //基本属性
            textBox标题.Text = zGraphTest.m_SyStitle.ToString();
            textBoxX轴名称.Text = zGraphTest.m_SySnameX.ToString();
            textBoxY轴名称.Text = zGraphTest.m_SySnameY.ToString();
            //样式
            textBox标题字体大小.Text = zGraphTest.m_titleSize.ToString();
            textBox标题位置.Text = zGraphTest.m_titlePosition.ToString();
            button标题颜色.BackColor = zGraphTest.m_titleColor;
            button标题描边颜色.BackColor = zGraphTest.m_titleBorderColor;
            button背景色渐进起始颜色.BackColor = zGraphTest.m_backColorL;
            button背景色渐进终止颜色.BackColor = zGraphTest.m_backColorH;
            button坐标线颜色.BackColor = zGraphTest.m_coordinateLineColor;
            button坐标值颜色.BackColor = zGraphTest.m_coordinateStringColor;
            button坐标标题颜色.BackColor = zGraphTest.m_coordinateStringTitleColor;
            textBox网络线的透明度.Text = zGraphTest.m_iLineShowColorAlpha.ToString();
            button网络线的颜色.BackColor = zGraphTest.m_iLineShowColor;
            button波形显示区域背景色.BackColor = zGraphTest.m_GraphBackColor;
            button工具栏背景色.BackColor = zGraphTest.m_ControlItemBackColor;
            button工具栏按钮背景色.BackColor = zGraphTest.m_ControlButtonBackColor;
            button工具栏按钮前景选中颜色.BackColor = zGraphTest.m_ControlButtonForeColorL;
            button工具栏按钮前景未选中颜色.BackColor = zGraphTest.m_ControlButtonForeColorH;
            button标签说明框背景颜色.BackColor = zGraphTest.m_DirectionBackColor;
            button标签说明框文字颜色.BackColor = zGraphTest.m_DirectionForeColor;
            button放大选取框背景颜色.BackColor = zGraphTest.m_BigXYBackColor;
            button放大选取框按钮背景颜色.BackColor = zGraphTest.m_BigXYButtonBackColor;
            button放大选取框按钮文字颜色.BackColor = zGraphTest.m_BigXYButtonForeColor;
        }

        private void button标题字体大小_Click(object sender, EventArgs e)
        {
            button标题字体大小.Enabled = false;
            this.Focus();
            int current;
            if(int.TryParse(textBox标题字体大小.Text.ToString(),out current))
            {
                if (current >= 9 && current <= 19)
                {
                    zGraphTest.m_titleSize = current;
                    zGraphTest.Refresh();
                }
                else
                {
                    textBox标题字体大小.Text = zGraphTest.m_titleSize.ToString();
                }
            }
            else
            {
                textBox标题字体大小.Text = zGraphTest.m_titleSize.ToString();
            }
            button标题字体大小.Enabled = true;
        }

        private void textBox标题字体大小_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button标题字体大小_Click(sender,e);
            }
        }

        private void button标题位置_Click(object sender, EventArgs e)
        {
            button标题位置.Enabled = false;
            this.Focus();
            float current;
            if (float.TryParse(textBox标题位置.Text.ToString(), out current))
            {
                if (current > 0 && current < 1)
                {
                    zGraphTest.m_titlePosition = current;
                    zGraphTest.Refresh();
                }
                else
                {
                    textBox标题位置.Text = zGraphTest.m_titlePosition.ToString();
                }
            }
            else
            {
                textBox标题位置.Text = zGraphTest.m_titlePosition.ToString();
            }
            button标题位置.Enabled = true;
        }

        private void textBox标题位置_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button标题位置_Click(sender, e);
            }
        }

        private void button标题颜色_Click(object sender, EventArgs e)
        {
            button标题颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_titleColor = my.Color;
                zGraphTest.Refresh();
                button标题颜色.BackColor = zGraphTest.m_titleColor;
            }
            button标题颜色.Enabled = true;
        }

        private void button标题描边颜色_Click(object sender, EventArgs e)
        {
            button标题描边颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_titleBorderColor = my.Color;
                zGraphTest.Refresh();
                button标题描边颜色.BackColor = zGraphTest.m_titleBorderColor;
            }
            button标题描边颜色.Enabled = true;
        }

        private void button背景色渐进起始颜色_Click(object sender, EventArgs e)
        {
            button背景色渐进起始颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_backColorL = my.Color;
                zGraphTest.Refresh();
                button背景色渐进起始颜色.BackColor = zGraphTest.m_backColorL;
            }
            button背景色渐进起始颜色.Enabled = true;
        }

        private void button背景色渐进终止颜色_Click(object sender, EventArgs e)
        {
            button背景色渐进终止颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_backColorH = my.Color;
                zGraphTest.Refresh();
                button背景色渐进终止颜色.BackColor = zGraphTest.m_backColorH;
            }
            button背景色渐进终止颜色.Enabled = true;
        }

        private void button坐标线颜色_Click(object sender, EventArgs e)
        {
            button坐标线颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_coordinateLineColor = my.Color;
                zGraphTest.Refresh();
                button坐标线颜色.BackColor = zGraphTest.m_coordinateLineColor;
            }
            button坐标线颜色.Enabled = true;
        }

        private void button坐标值颜色_Click(object sender, EventArgs e)
        {
            button坐标值颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_coordinateStringColor = my.Color;
                zGraphTest.Refresh();
                button坐标值颜色.BackColor = zGraphTest.m_coordinateStringColor;
            }
            button坐标值颜色.Enabled = true;
        }

        private void button坐标标题颜色_Click(object sender, EventArgs e)
        {
            button坐标标题颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_coordinateStringTitleColor = my.Color;
                zGraphTest.Refresh();
                button坐标标题颜色.BackColor = zGraphTest.m_coordinateStringTitleColor;
            }
            button坐标标题颜色.Enabled = true;
        }

        private void button网络线的透明度_Click(object sender, EventArgs e)
        {
            button网络线的透明度.Enabled = false;
            this.Focus();
            int current;
            if (int.TryParse(textBox网络线的透明度.Text.ToString(), out current))
            {
                if (current > 10 && current < 256)
                {
                    zGraphTest.m_iLineShowColorAlpha = current;
                    zGraphTest.Refresh();
                }
                else
                {
                    textBox网络线的透明度.Text = zGraphTest.m_iLineShowColorAlpha.ToString();
                }
            }
            else
            {
                textBox网络线的透明度.Text = zGraphTest.m_iLineShowColorAlpha.ToString();
            }
            button网络线的透明度.Enabled = true;
        }

        private void textBox网络线的透明度_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button网络线的透明度_Click(sender, e);
            }
        }

        private void button网络线的颜色_Click(object sender, EventArgs e)
        {
            button网络线的颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_iLineShowColor = my.Color;
                zGraphTest.Refresh();
                button网络线的颜色.BackColor = zGraphTest.m_iLineShowColor;
            }
            button网络线的颜色.Enabled = true;
        }

        private void button工具栏背景色_Click(object sender, EventArgs e)
        {
            button工具栏背景色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_ControlItemBackColor = my.Color;
                zGraphTest.Refresh();
                button工具栏背景色.BackColor = zGraphTest.m_ControlItemBackColor;
            }
            button工具栏背景色.Enabled = true;
        }

        private void button波形显示区域背景色_Click(object sender, EventArgs e)
        {
            button波形显示区域背景色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_GraphBackColor = my.Color;
                zGraphTest.Refresh();
                button波形显示区域背景色.BackColor = zGraphTest.m_GraphBackColor;
            }
            button波形显示区域背景色.Enabled = true;
        }

        private void button工具栏按钮背景色_Click(object sender, EventArgs e)
        {
            button工具栏按钮背景色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_ControlButtonBackColor = my.Color;
                zGraphTest.Refresh();
                button工具栏按钮背景色.BackColor = zGraphTest.m_ControlButtonBackColor;
            }
            button工具栏按钮背景色.Enabled = true;
        }

        private void button工具栏按钮前景选中颜色_Click(object sender, EventArgs e)
        {
            button工具栏按钮前景选中颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_ControlButtonForeColorL = my.Color;
                zGraphTest.Refresh();
                button工具栏按钮前景选中颜色.BackColor = zGraphTest.m_ControlButtonForeColorL;
            }
            button工具栏按钮前景选中颜色.Enabled = true;
        }

        private void button工具栏按钮前景未选中颜色_Click(object sender, EventArgs e)
        {
            button工具栏按钮前景未选中颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_ControlButtonForeColorH = my.Color;
                zGraphTest.Refresh();
                button工具栏按钮前景未选中颜色.BackColor = zGraphTest.m_ControlButtonForeColorH;
            }
            button工具栏按钮前景未选中颜色.Enabled = true;
        }

        private void button标签说明框背景颜色_Click(object sender, EventArgs e)
        {
            button标签说明框背景颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_DirectionBackColor = my.Color;
                zGraphTest.Refresh();
                button标签说明框背景颜色.BackColor = zGraphTest.m_DirectionBackColor;
            }
            button标签说明框背景颜色.Enabled = true;
        }

        private void button标签说明框文字颜色_Click(object sender, EventArgs e)
        {
            button标签说明框文字颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_DirectionForeColor = my.Color;
                zGraphTest.Refresh();
                button标签说明框文字颜色.BackColor = zGraphTest.m_DirectionForeColor;
            }
            button标签说明框文字颜色.Enabled = true;
        }

        private void button放大选取框背景颜色_Click(object sender, EventArgs e)
        {
            button放大选取框背景颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_BigXYBackColor = my.Color;
                zGraphTest.Refresh();
                button放大选取框背景颜色.BackColor = zGraphTest.m_BigXYBackColor;
            }
            button放大选取框背景颜色.Enabled = true;
        }

        private void button放大选取框按钮背景颜色_Click(object sender, EventArgs e)
        {
            button放大选取框按钮背景颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_BigXYButtonBackColor = my.Color;
                zGraphTest.Refresh();
                button放大选取框按钮背景颜色.BackColor = zGraphTest.m_BigXYButtonBackColor;
            }
            button放大选取框按钮背景颜色.Enabled = true;
        }

        private void button放大选取框按钮文字颜色_Click(object sender, EventArgs e)
        {
            button放大选取框按钮文字颜色.Enabled = false;
            this.Focus();
            ColorDialog my = new ColorDialog();
            if (DialogResult.OK == my.ShowDialog())
            {
                zGraphTest.m_BigXYButtonForeColor = my.Color;
                zGraphTest.Refresh();
                button放大选取框按钮文字颜色.BackColor = zGraphTest.m_BigXYButtonForeColor;
            }
            button放大选取框按钮文字颜色.Enabled = true;
        }

        private void button标题_Click(object sender, EventArgs e)
        {
            button标题.Enabled = false;
            this.Focus();
            zGraphTest.m_SyStitle = textBox标题.Text.ToString();
            zGraphTest.Refresh();
            button标题.Enabled = true;
        }

        private void textBox标题_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button标题_Click(sender, e);
            }
        }

        private void buttonX轴名称_Click(object sender, EventArgs e)
        {
            buttonX轴名称.Enabled = false;
            this.Focus();
            zGraphTest.m_SySnameX = textBoxX轴名称.Text.ToString();
            zGraphTest.Refresh();
            buttonX轴名称.Enabled = true;
        }

        private void textBoxX轴名称_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonX轴名称_Click(sender, e);
            }
        }

        private void buttonY轴名称_Click(object sender, EventArgs e)
        {
            buttonY轴名称.Enabled = false;
            this.Focus();
            zGraphTest.m_SySnameY = textBoxY轴名称.Text.ToString();
            zGraphTest.Refresh();
            buttonY轴名称.Enabled = true;
        }

        private void textBoxY轴名称_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonY轴名称_Click(sender, e);
            }
        }

        private void button默认样式_Click(object sender, EventArgs e)
        {
            button默认样式.Enabled = false;
            this.Focus();
            f_saveReadFirst(true);
            zGraphTest.Refresh();
            button默认样式.Enabled = true;
        }

        private void button参考样式1_Click(object sender, EventArgs e)
        {
            button参考样式1.Enabled = false;
            this.Focus();
            zGraphTest.m_titleSize = 15;
            zGraphTest.m_titlePosition = 0.4f;
            zGraphTest.m_titleColor = Color.FromArgb(255, 255, 255);
            zGraphTest.m_titleBorderColor = Color.FromArgb(0, 64, 128);
            zGraphTest.m_backColorL = Color.FromArgb(0, 0, 0);
            zGraphTest.m_backColorH = Color.FromArgb(0, 64, 128);
            zGraphTest.m_coordinateLineColor = Color.FromArgb(0, 128, 255);
            zGraphTest.m_coordinateStringColor = Color.FromArgb(128, 255, 255);
            zGraphTest.m_coordinateStringTitleColor = Color.FromArgb(68, 189, 255);
            zGraphTest.m_iLineShowColorAlpha = 200;
            zGraphTest.m_iLineShowColor = Color.FromArgb(0, 128, 128);
            zGraphTest.m_GraphBackColor = Color.FromArgb(255, 255, 255);
            zGraphTest.m_ControlItemBackColor = Color.FromArgb(0, 64, 128);
            zGraphTest.m_ControlButtonBackColor = Color.FromArgb(0, 0, 0);
            zGraphTest.m_ControlButtonForeColorL = Color.FromArgb(0, 255, 255);
            zGraphTest.m_ControlButtonForeColorH = Color.FromArgb(0, 64, 128);
            zGraphTest.m_DirectionBackColor = Color.FromArgb(0, 0, 0);
            zGraphTest.m_DirectionForeColor = Color.FromArgb(255, 255, 0);
            zGraphTest.m_BigXYBackColor = Color.FromArgb(0, 64, 128);
            zGraphTest.m_BigXYButtonBackColor = Color.FromArgb(255, 128, 0);
            zGraphTest.m_BigXYButtonForeColor = Color.FromArgb(255, 255, 0);
            zGraphTest.Refresh();
            f_reStyle();
            button参考样式1.Enabled = true;
        }

        private void button参考样式2_Click(object sender, EventArgs e)
        {
            button参考样式2.Enabled = false;
            this.Focus();
            zGraphTest.m_titleSize = 14;
            zGraphTest.m_titlePosition = 0.4f;
            zGraphTest.m_titleColor = Color.FromArgb(255, 255, 255);
            zGraphTest.m_titleBorderColor = Color.FromArgb(255, 128, 64);
            zGraphTest.m_backColorL = Color.FromArgb(255, 128, 0);
            zGraphTest.m_backColorH = Color.FromArgb(255, 255, 0);
            zGraphTest.m_coordinateLineColor = Color.FromArgb(255, 255, 128);
            zGraphTest.m_coordinateStringColor = Color.FromArgb(255, 255, 128);
            zGraphTest.m_coordinateStringTitleColor = Color.FromArgb(255, 255, 255);
            zGraphTest.m_iLineShowColorAlpha = 200;
            zGraphTest.m_iLineShowColor = Color.FromArgb(255, 128, 0);
            zGraphTest.m_GraphBackColor = Color.FromArgb(255, 255, 128);
            zGraphTest.m_ControlItemBackColor = Color.FromArgb(255, 255, 0);
            zGraphTest.m_ControlButtonBackColor = Color.FromArgb(255, 128, 0);
            zGraphTest.m_ControlButtonForeColorL = Color.FromArgb(128, 0, 0);
            zGraphTest.m_ControlButtonForeColorH = Color.FromArgb(255, 255, 128);
            zGraphTest.m_DirectionBackColor = Color.FromArgb(0, 255, 0);
            zGraphTest.m_DirectionForeColor = Color.FromArgb(0, 0, 64);
            zGraphTest.m_BigXYBackColor = Color.FromArgb(255, 128, 64);
            zGraphTest.m_BigXYButtonBackColor = Color.FromArgb(255, 128, 0);
            zGraphTest.m_BigXYButtonForeColor = Color.FromArgb(255, 255, 0);
            zGraphTest.Refresh();
            f_reStyle();
            button参考样式2.Enabled = true;

        }





        #region **测试数据**
        public List<float> x1 = new List<float>();
        public List<float> y1 = new List<float>();
        public List<float> x2 = new List<float>();
        public List<float> y2 = new List<float>();
        public List<float> x3 = new List<float>();
        public List<float> y3 = new List<float>();
        public List<float> x4 = new List<float>();
        public List<float> y4 = new List<float>();
        #endregion

        private void button数据显示模拟1_Click(object sender, EventArgs e)
        {
            ///-300~num画四条数据
            button数据显示模拟1.Enabled = false;
            this.Focus();
            int num;
            textBox附加参数.Text = "";
            if (int.TryParse(textBox数值.Text.ToString(), out num))
            {
                if (num < -10000 || num > 10000)
                {
                    num = 1580;
                    textBox数值.Text = num.ToString();
                }
            }
            else
            {
                num = 1580;
                textBox数值.Text = num.ToString();
            }
            x1.Clear();
            y1.Clear();
            x2.Clear();
            y2.Clear();
            x3.Clear();
            y3.Clear();
            x4.Clear();
            y4.Clear();
            if (num < -300)
            {
                for (int i = -300; i > num; i--)
                {
                    x1.Add(i);
                    y1.Add(i % 1000);
                    x2.Add(i);
                    y2.Add((float)Math.Sin(i / 100f) * 200);
                    x3.Add(i);
                    y3.Add(0);
                    x4.Add(i);
                    y4.Add((float)Math.Sin(i / 100) * 200);
                }
            }
            else
            {
                for (int i = -300; i < num; i++)
                {
                    x1.Add(i);
                    y1.Add(i % 1000);
                    x2.Add(i);
                    y2.Add((float)Math.Sin(i / 100f) * 200);
                    x3.Add(i);
                    y3.Add(0);
                    x4.Add(i);
                    y4.Add((float)Math.Sin(i / 100) * 200);
                }
            }
            zGraphTest.f_ClearAllPix();
            zGraphTest.f_reXY();
            zGraphTest.f_LoadOnePix(ref x1, ref y1, Color.Red, 2);
            zGraphTest.f_AddPix(ref x2, ref y2, Color.Blue, 4);
            zGraphTest.f_AddPix(ref x3, ref y3, Color.FromArgb(0, 128, 192), 2);
            zGraphTest.f_AddPix(ref x4, ref y4, Color.Yellow, 4);
            zGraphTest.f_Refresh();
            button数据显示模拟1.Enabled = true;
        }

        private void button数据显示模拟2_Click(object sender, EventArgs e)
        {
            ///画三条数据[点|线|矩形条]
            button数据显示模拟2.Enabled = false;
            this.Focus();
            textBox数值.Text = "";
            textBox附加参数.Text = "";
            x1.Clear();
            y1.Clear();
            x2.Clear();
            y2.Clear();
            x3.Clear();
            y3.Clear();
            for (int i = 0; i < 18000; i += 1000)
            {
                x1.Add(i);
                y1.Add(i/4f);
                x2.Add(i);
                y2.Add(i/4f);
                x3.Add(i);
                y3.Add(i / 8f);
            }
            zGraphTest.f_ClearAllPix();
            zGraphTest.f_reXY();
            zGraphTest.f_LoadOnePix(ref x1, ref y1, Color.Red, 3);
            zGraphTest.f_AddPix(ref x2, ref y2, Color.Yellow, 5, LineJoin.Round, LineCap.Flat, ZhengJuyin.UI.ZGraph.DrawStyle.dot);
            zGraphTest.f_AddPix(ref x3, ref y3, Color.FromArgb(0,128,192), 12, LineJoin.MiterClipped, LineCap.NoAnchor, ZhengJuyin.UI.ZGraph.DrawStyle.bar);
            zGraphTest.f_Refresh();
            button数据显示模拟2.Enabled = true;
        }

        private void button数据显示模拟3_Click(object sender, EventArgs e)
        {
            ///模拟串口采样显示[周期k]
            button数据显示模拟3.Enabled = false;
            this.Focus();
            textBox数值.Text = "";
            int current;
            if (int.TryParse(textBox附加参数.Text.ToString(), out current))
            {
                if (current > 100 && current < 300)
                {
                    timerDraw.Interval = current;
                }
                else
                {
                    textBox附加参数.Text = "200";
                }
            }
            else
            {
                textBox附加参数.Text = "200";
            }
            x1.Clear();
            y1.Clear();
            x2.Clear();
            y2.Clear();
            x3.Clear();
            y3.Clear();
            x4.Clear();
            y4.Clear();
            zGraphTest.f_ClearAllPix();
            zGraphTest.f_reXY();
            zGraphTest.f_LoadOnePix(ref x1, ref y1, Color.Red, 2);
            zGraphTest.f_AddPix(ref x2, ref y2, Color.Blue, 3);
            zGraphTest.f_AddPix(ref x3, ref y3, Color.FromArgb(0, 128, 192), 2);
            zGraphTest.f_AddPix(ref x4, ref y4, Color.Yellow, 3);

            f_timerDrawStart(); //开始TIMER
            //更新按钮显示，表示为正在采样
            button数据显示模拟3.Text += " 正在采样";
            button数据显示模拟3.TextAlign = ContentAlignment.MiddleLeft;
        }

        private int timerDrawI = 0;
        private void timerDraw_Tick(object sender, EventArgs e)
        {
            ///TIME增加数据
            x1.Add(timerDrawI);
            y1.Add(timerDrawI % 100);
            x2.Add(timerDrawI);
            y2.Add((float)Math.Sin(timerDrawI / 10f) * 200);
            x3.Add(timerDrawI);
            y3.Add(50);
            x4.Add(timerDrawI);
            y4.Add((float)Math.Sin(timerDrawI / 10) * 200);
            timerDrawI++;
            zGraphTest.f_Refresh();
            //更新按钮显示，表示为正在采样
            button数据显示模拟3.Text += ".";
            if (button数据显示模拟3.Text.Length > 22)
            {
                button数据显示模拟3.Text = "模拟串口采样[周期k] 正在采样.";
            }
        }

        private void f_timerDrawStart()
        {
            timerDrawI = 0;
            timerDraw.Start();
            textBox附加参数.ReadOnly = true;
            textBox数值.ReadOnly = true;
            button数据显示模拟1.Enabled = false;
            button数据显示模拟2.Enabled = false;
            button数据显示模拟3.Enabled = false;
            button数据显示模拟5.Enabled = false;
            button数据显示模拟6.Enabled = false;
            button数据显示模拟7.Enabled = false;
        }

        private void f_timerDrawStop()
        {
            timerDraw.Stop();
            textBox附加参数.ReadOnly = false;
            textBox数值.ReadOnly = false;
            button数据显示模拟1.Enabled = true;
            button数据显示模拟2.Enabled = true;
            button数据显示模拟3.Enabled = true;
            button数据显示模拟5.Enabled = true;
            button数据显示模拟6.Enabled = true;
            button数据显示模拟7.Enabled = true;
            button数据显示模拟3.Text = "模拟串口采样[周期k]";
            button数据显示模拟3.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void button数据显示模拟4_Click(object sender, EventArgs e)
        {
            ///关闭TIMER
            button数据显示模拟4.Enabled = false;
            this.Focus();
            f_timerDrawStop();
            button数据显示模拟4.Enabled = true;
        }

        private void button数据显示模拟5_Click(object sender, EventArgs e)
        {
            ///随机点的显示[周期k]
            button数据显示模拟5.Enabled = false;
            this.Focus();
            textBox数值.Text = "";
            int current;
            if (int.TryParse(textBox附加参数.Text.ToString(), out current))
            {
                if (current > 50 && current < 300)
                {
                    timerRandom.Interval = current;
                }
                else
                {
                    textBox附加参数.Text = "100";
                }
            }
            else
            {
                textBox附加参数.Text = "100";
            }
            x1.Clear();
            y1.Clear();
            zGraphTest.f_ClearAllPix();
            zGraphTest.f_reXY();
            zGraphTest.f_LoadOnePix(ref x1, ref y1, Color.Red, 2, LineJoin.Round, LineCap.NoAnchor, ZhengJuyin.UI.ZGraph.DrawStyle.dot);

            f_timerRandomStart(); //开始TIMER
            //更新按钮显示，表示为正在采样
            button数据显示模拟5.Text += " 正在采样";
            button数据显示模拟5.TextAlign = ContentAlignment.MiddleLeft;

        }
        Random rand = new Random();
        private void timerRandom_Tick(object sender, EventArgs e)
        {
            
            x1.Add(rand.Next(60));
            y1.Add((float)rand.NextDouble());
            zGraphTest.f_Refresh();
            //更新按钮显示，表示为正在采样
            button数据显示模拟5.Text += ".";
            if (button数据显示模拟5.Text.Length > 22)
            {
                button数据显示模拟5.Text = "随机点的显示[周期k] 正在采样.";
            }
        }

        private void f_timerRandomStart()
        {
            timerRandom.Start();
            textBox附加参数.ReadOnly = true;
            textBox数值.ReadOnly = true;
            button数据显示模拟1.Enabled = false;
            button数据显示模拟2.Enabled = false;
            button数据显示模拟3.Enabled = false;
            button数据显示模拟4.Enabled = false;
            button数据显示模拟5.Enabled = false;
            button数据显示模拟7.Enabled = false;
        }

        private void f_timerRandomStop()
        {
            timerRandom.Stop();
            textBox附加参数.ReadOnly = false;
            textBox数值.ReadOnly = false;
            button数据显示模拟1.Enabled = true;
            button数据显示模拟2.Enabled = true;
            button数据显示模拟3.Enabled = true;
            button数据显示模拟4.Enabled = true;
            button数据显示模拟5.Enabled = true;
            button数据显示模拟7.Enabled = true;
            button数据显示模拟5.Text = "随机点的显示[周期k]";
            button数据显示模拟5.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void button数据显示模拟6_Click(object sender, EventArgs e)
        {
            button数据显示模拟6.Enabled = false;
            this.Focus();
            f_timerRandomStop();
            button数据显示模拟6.Enabled = true;
        }

        private void button数据显示模拟7_Click(object sender, EventArgs e)
        {
            timerDraw.Stop();
            zGraphTest.f_ClearAllPix();
        }






    }
}