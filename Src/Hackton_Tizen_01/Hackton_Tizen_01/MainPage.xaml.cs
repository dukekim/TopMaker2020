using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tizen.Network.Bluetooth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tizen;

namespace Hackton_Tizen_01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private readonly string TAG = "BT_TAG";

        private void DDD(string txt)
        {
            Debug.WriteLine(txt);
            Tizen.Log.Debug(TAG, txt);
        }

        public MainPage()
        {
            Debug.WriteLine("MainPage");
            InitializeComponent();
        }

        private void BtnConnection_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("BtnConnection_Clicked");
            DDD("BtnConnection_Clicked");

            /// Get the bonded device list
            IEnumerable<BluetoothDevice> list = BluetoothAdapter.GetBondedDevices();
            if (!list.Any())
            {
                DDD("No bonded devices are found.");
                lbl_BLE_status.Text = "No bonded devices are found.";
            }
            else
            {
                foreach (BluetoothDevice item in list)
                {
                    /// Logic to process the device information
                    BondedDeviceTest(item);
                    lbl_BLE_status.Text = item.Address + " Connected";
                }
            }
        }

        public static void BondedDeviceTest(BluetoothDevice item)
        {
            if (item.Address != null && item.Name != null && item.IsPaired && item.ServiceUuidList != null)
            {
                //DBG("[BondedDeviceTest] " + item.Address  + item.Name);
                Debug.WriteLine("[BondedDeviceTest] " + item.Address + item.Name);
            }
        }

        private void Btn_00_khi(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_00_khi clicked");
        }

        private void Btn_01_kstr(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_01_kstr clicked");
        }

        private void Btn_02_ksit(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_02_ksit clicked");
        }

        private void Btn_10_kbuttUp(object sender, EventArgs e)
        {
            Log.Debug(TAG, " clicked");
        }

        private void Btn_11_kpu(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_10_kbuttUp clicked");
        }

        private void Btn_12_kpee(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_12_kpee clicked");
        }

        private void Btn_20_kbd(object sender, EventArgs e)
        {
            Log.Debug(TAG, " clicked");
        }

        private void Btn_21_kdropped(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_21_kdropped clicked");
        }

        private void Btn_22_ktb(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_22_ktb clicked");
        }

        private void Btn_30_kvt(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_30_kvt clicked");
        }

        private void Btn_31_krc(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_31_krc clicked");
        }

        private void Btn_kbalance(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_kbalance clicked");
        }

        private void Btn_UP_kwk(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_UP_kwk clicked");
        }

        private void Btn_Left_kwkL(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_L_kwkL clicked");
        }

        private void Btn_Right_kwkR(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_R_kwkR clicked");
        }

        private void Btn_Down_kbk(object sender, EventArgs e)
        {
            Log.Debug(TAG, "Btn_Dn_kbk clicked");
        }
    }
}