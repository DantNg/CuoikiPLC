using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using System.Data.SqlClient;

namespace Cuoiki
{
    public partial class MainHMI : Form
    {
        AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
        SqlConnection strcon = new SqlConnection(@"Data Source=DESKTOP-5SRCC15\SQLEXPRESS;Initial Catalog=ManagerAccount;Integrated Security=True");
        
        bool isConnected = false; // biến sẽ chuyển thành true khi connect và cho phép hệ thống chạy; 

        Plc myPlc;
        byte[] ReadSystem = new byte[2];
        byte[] ReadStateXilo = new byte[10];
        byte[] ReadState = new byte[2];
        byte[] ReadSensorMixTankLow = new byte[2];
        byte[] ReadSensorMixTankHight = new byte[2];
        PlcCom PlcCom = new PlcCom();
        ReadInput ReadInput = new ReadInput();
        double doSetMixTime;
        double doActMixTime;
        int[] SensorMixTank = new int[3];
        
        private void connectIpBtn_Click(object sender, EventArgs e)
        {
            autoComplete.Add(ipEntryBox.Text);
            if (isConnected)
            {
                isConnected = false;
                Connected.Visible = false;
                Disconnected.Visible = true;
            }
            else
            {
                isConnected = true;
                Connected.Visible = true;
                Disconnected.Visible = false;
            }
            if (isConnected && ipEntryBox.Text != null)
            {
                
                myPlc = new Plc(CpuType.S71200, ipEntryBox.Text, 0, 1);
                myPlc.Open();
                TimerRead.Enabled = true;
                TimerRead.Interval = 300;
            }
        }
        public MainHMI()
        {
            InitializeComponent();
        }

        private void MainHMI_Load(object sender, EventArgs e)
        {
            ipEntryBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ipEntryBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //auto.Add(textBox1.Text);
            ipEntryBox.AutoCompleteCustomSource = autoComplete;
            if (isConnected)
            {
               
            }
        }

        private void TimerRead_Tick(object sender, EventArgs e)
        {
            if (isConnected)
            {
                #region Doc trang thai He thong
                ReadSystem = myPlc.ReadBytes(DataType.Memory, 0, 0, 1);
                if (ReadSystem[0].SelectBit(2))
                {
                    stControlOn.DiscreteValue1 = true;
                    stControlOn.DiscreteValue2 = false;
                }
                else
                {
                    stControlOn.DiscreteValue1 = false;
                    stControlOn.DiscreteValue2 = true;
                }
                #endregion

                #region Doc trang thai Xilo
                ReadStateXilo = myPlc.ReadBytes(DataType.Output, 0, 0, 3);
                if (ReadStateXilo[0].SelectBit(0))
                {
                    stXiloRice1.DiscreteValue1 = true;
                }
                else
                {
                    stXiloRice1.DiscreteValue1 = false;
                }
                if (ReadStateXilo[0].SelectBit(1))
                {
                    stXiloRice2.DiscreteValue1 = true;
                }
                else
                {
                    stXiloRice2.DiscreteValue1 = false;
                }
                if (ReadStateXilo[0].SelectBit(2))
                {
                    stXiloRice3.DiscreteValue1 = true;
                }
                else
                {
                    stXiloRice3.DiscreteValue1 = false;
                }
                if (ReadStateXilo[0].SelectBit(3))
                {
                    stXiloCorn4.DiscreteValue1 = true;
                }
                else
                {
                    stXiloCorn4.DiscreteValue1 = false;
                }
                if (ReadStateXilo[0].SelectBit(4))
                {
                    stXiloCorn5.DiscreteValue1 = true;
                }
                else
                {
                    stXiloCorn5.DiscreteValue1 = false;
                }
                if (ReadStateXilo[0].SelectBit(5))
                {
                    stXiloCorn6.DiscreteValue1 = true;
                }
                else
                {
                    stXiloCorn6.DiscreteValue1 = false;
                }
                if (ReadStateXilo[0].SelectBit(6))
                {
                    stXiloCorn7.DiscreteValue1 = true;
                }
                else
                {
                    stXiloCorn7.DiscreteValue1 = false;
                }
                if (ReadStateXilo[0].SelectBit(7))
                {
                    stXiloCassava8.DiscreteValue1 = true;
                }
                else
                {
                    stXiloCassava8.DiscreteValue1 = false;
                }
                if (ReadStateXilo[1].SelectBit(0))
                {
                    stXiloCassava9.DiscreteValue1 = true;
                }
                else
                {
                    stXiloCassava9.DiscreteValue1 = false;
                }
                if (ReadStateXilo[1].SelectBit(1))
                {
                    stXiloBean10.DiscreteValue1 = true;
                }
                else
                {
                    stXiloBean10.DiscreteValue1 = false;
                }
                if (ReadStateXilo[1].SelectBit(2))
                {
                    stXiloBean11.DiscreteValue1 = true;
                }
                else
                {
                    stXiloBean11.DiscreteValue1 = false;
                }
                if (ReadStateXilo[1].SelectBit(3))
                {
                    stXiloBean12.DiscreteValue1 = true;
                }
                else
                {
                    stXiloBean12.DiscreteValue1 = false;
                }
                if (ReadStateXilo[1].SelectBit(4)) //Doc trang thai xilo 13
                {
                    stXiloFish13.DiscreteValue1 = true;
                }
                else
                {
                    stXiloFish13.DiscreteValue1 = false;
                }
                if (ReadStateXilo[1].SelectBit(5)) //Doc trang thai xilo 14
                {
                    stXiloFish14.DiscreteValue1 = true;
                }
                else
                {
                    stXiloFish14.DiscreteValue1 = false;
                }
                if (ReadStateXilo[1].SelectBit(6)) //Doc trang thai xilo 15
                {
                    stXiloFish15.DiscreteValue1 = true;
                }
                else
                {
                    stXiloFish15.DiscreteValue1 = false;
                }
                if (ReadStateXilo[1].SelectBit(7)) //Doc trang thai xilo 16
                {
                    stXiloFish16.DiscreteValue1 = true;
                }
                else
                {
                    stXiloFish16.DiscreteValue1 = false;
                }
                #endregion

                #region Giam sat noi tron
                ReadState = myPlc.ReadBytes(DataType.Output, 0, 2, 1);
                if (ReadState[0].SelectBit(0))
                {
                    stValveScale1.DiscreteValue1 = true;
                }
                else
                {
                    stValveScale1.DiscreteValue1 = false;
                }

                if (ReadState[0].SelectBit(1))
                {
                    stValveScale2.DiscreteValue1 = true;
                }
                else
                {
                    stValveScale2.DiscreteValue1 = false;
                }

                if (ReadState[0].SelectBit(2))
                {
                    stMixMotor.DiscreteValue1 = true;
                }
                else
                {
                    stMixMotor.DiscreteValue1 = false;
                }

                if (ReadState[0].SelectBit(3))
                {
                    stValveMixTank.DiscreteValue1 = true;
                }
                else
                {
                    stValveMixTank.DiscreteValue1 = false;
                }
                #endregion

                #region Doc trong luong moi can
                myPlc.ReadClass(PlcCom, 4);
                lbScale1.Text = Math.Round(PlcCom.ActScale1, 3).ToString();
                lbScale2.Text = Math.Round(PlcCom.ActScale2, 3).ToString();
                doActMixTime = Convert.ToDouble(myPlc.Read("DB4.DBD8")) / 1000;
                lbTimer.Text = doActMixTime.ToString();
                myPlc.ReadClass(ReadInput, 3);
                lbInputRice.Text = Math.Round(ReadInput.InputRice, 3).ToString();
                lbInputCorn.Text = Math.Round(ReadInput.InputCorn, 3).ToString();
                lbInputCassava.Text = Math.Round(ReadInput.InputCassava, 3).ToString();
                lbInputBean.Text = Math.Round(ReadInput.InputBean, 3).ToString();
                lbInputFish.Text = Math.Round(ReadInput.InputFish, 3).ToString();
                doSetMixTime = Convert.ToDouble(myPlc.Read("DB3.DBD20")) / 1000;
                lbSetMixTime.Text = doSetMixTime.ToString();
                #endregion

                #region Doc trang thai cam bien noi tron
                ReadSensorMixTankLow = myPlc.ReadBytes(DataType.Memory, 0, 5, 1);
                ReadSensorMixTankHight = myPlc.ReadBytes(DataType.Memory, 0, 2, 1);
                if (ReadSensorMixTankLow[0].SelectBit(0))
                {
                    stSensorMixTankLow.DiscreteValue1 = true;
                }
                else
                {
                    stSensorMixTankLow.DiscreteValue1 = false;
                }
                if (ReadSensorMixTankHight[0].SelectBit(5))
                {
                    stSensorMixTankHight.DiscreteValue1 = true;
                }
                else
                {
                    stSensorMixTankHight.DiscreteValue1 = false;
                }
                #endregion
            }
        }

        private void btOn_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                myPlc.WriteBit(DataType.Memory, 0, 0, 0, 1);
                myPlc.WriteBit(DataType.Memory, 0, 0, 0, 0);
            }
        }

        private void btOff_Click(object sender, EventArgs e)
        { 
        if (isConnected)
            {
                myPlc.WriteBit(DataType.Memory, 0, 0, 1, 1);
                myPlc.WriteBit(DataType.Memory, 0, 0, 1, 0);
            }
        }

        private void btEnablePourToScale_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                myPlc.Write("DB3.DBD0", double.Parse(txtInputRice.Text));
                myPlc.Write("DB3.DBD4", double.Parse(txtInputCorn.Text));
                myPlc.Write("DB3.DBD8", double.Parse(txtInputCassava.Text));
                myPlc.Write("DB3.DBD12", double.Parse(txtInputBean.Text));
                myPlc.Write("DB3.DBD16", double.Parse(txtInputFish.Text));
                myPlc.WriteBit(DataType.Memory, 0, 2, 6, 1);
                myPlc.Write("DB3.DBD20", (int.Parse(txtInputHour.Text) * 3600 + int.Parse(txtInputMins.Text) * 60 + int.Parse(txtInputSecond.Text)) * 1000);
                MessageBox.Show("Nhap thoi gian tron,nguyen lieu thanh cong !!!");
                try
                {
                    if (strcon.State == ConnectionState.Closed)
                        strcon.Open();
                    SqlCommand insert = new SqlCommand("insert into RecipeDiary values (@Rice,@Corn,@Cassava,@Bean,@Fish,@MixTime,@Time,@Date)", strcon);
                    insert.Parameters.AddWithValue("@Rice", txtInputRice.Text);
                    insert.Parameters.AddWithValue("@Corn", txtInputCorn.Text);
                    insert.Parameters.AddWithValue("@Cassava", txtInputCassava.Text);
                    insert.Parameters.AddWithValue("@Bean", txtInputBean.Text);
                    insert.Parameters.AddWithValue("@Fish", txtInputFish.Text);
                    insert.Parameters.AddWithValue("@MixTime", doSetMixTime);
                    insert.Parameters.AddWithValue("@Time", DateTime.Now.ToLongTimeString());
                    insert.Parameters.AddWithValue("@Date", DateTime.Today.ToString("dd/MM/yyyy"));
                    insert.ExecuteNonQuery();
                    if (strcon.State == ConnectionState.Open)
                        strcon.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "Error");
                }
            }
        }

        private void btSensorMixTankHight_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (SensorMixTank[0] == 0)
                {
                    myPlc.WriteBit(DataType.Memory, 0, 2, 5, 1);
                    btSensorMixTankHight.BackColor = Color.FromArgb(0, 243, 0);
                    SensorMixTank[0] = 1;
                }
                else
                {
                    myPlc.WriteBit(DataType.Memory, 0, 2, 5, 0);
                    btSensorMixTankHight.BackColor = Color.FromArgb(255, 255, 192);
                    SensorMixTank[0] = 0;
                }
            }
        }

        private void btSensorMixTankLow_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (SensorMixTank[1] == 0)
                {
                    myPlc.WriteBit(DataType.Memory, 0, 5, 0, 1);
                    btSensorMixTankLow.BackColor = Color.FromArgb(0, 243, 0);
                    SensorMixTank[1] = 1;
                }
                else
                {
                    myPlc.WriteBit(DataType.Memory, 0, 5, 0, 0);
                    btSensorMixTankLow.BackColor = Color.FromArgb(255, 255, 192);
                    SensorMixTank[1] = 0;
                }
            }
        }

     
    }
}
