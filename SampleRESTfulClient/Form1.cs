using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleRESTfulClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static async Task<SAMPLE_STRUCT> GetSampleRestful(string address)
        {
            SAMPLE_STRUCT data;
            using (var client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 0, 10);
                try
                {
                    //Uid
                    var response = await client.GetAsync(address);
                    //Console.WriteLine("{0} ({1}) {2}", (int)response.StatusCode, response.ReasonPhrase, response.Content);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = response.Content.ReadAsStringAsync().Result;
                        data = JsonConvert.DeserializeObject<SAMPLE_STRUCT>(jsonString);
                        return data;
                    }
                    else
                    {
                        string failedMessage = $"Failed GetSampleRestful StatusCode:{response.StatusCode} ReasonPhrase:{response.ReasonPhrase}";
                        Console.WriteLine(failedMessage);
                    }
                }
                catch (TaskCanceledException tce)
                {
                    Console.WriteLine(tce.Message);
                    Console.WriteLine(tce.StackTrace);
                }
                catch (HttpRequestException hre)
                {
                    Console.WriteLine(hre.Message);
                    Console.WriteLine(hre.StackTrace);
                }
            }
            return new();
        }

        public static async Task<bool> PostSampleRestful(string address, SAMPLE_STRUCT data)
        {
            using (var client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 0, 10);
                try
                {
                    string jsonString = JsonConvert.SerializeObject(data);
                    var response = await client.PostAsync(address,
                    new StringContent(jsonString, Encoding.UTF8, "application/json"));
                    //Console.WriteLine("{0} ({1}) {2}", (int)response.StatusCode, response.ReasonPhrase, response.Content);

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        string failedMessage = $"Failed PostSampleRestful StatusCode:{response.StatusCode} ReasonPhrase:{response.ReasonPhrase}";
                        Console.WriteLine(failedMessage);
                    }
                }
                catch (TaskCanceledException tce)
                {
                    Console.WriteLine(tce.Message);
                    Console.WriteLine(tce.StackTrace);
                }
                catch (HttpRequestException hre)
                {
                    Console.WriteLine(hre.Message);
                    Console.WriteLine(hre.StackTrace);
                }
            }
            return false;
        }

        private void ButtonGet_Click(object sender, EventArgs e)
        {
            string address = textBoxGetAddress.Text;
            if (address.Length <= 0)
            {
                MessageBox.Show(new Form() { WindowState = FormWindowState.Maximized, TopMost = true },
                    "no input get address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var task = Task.Run(() => GetSampleRestful(address));
            task.ContinueWith(x =>
            {
                SAMPLE_STRUCT data = x.Result;
                textBoxGetId.Text = data.Id;
                textBoxGetData1.Text = data.Data1;
                textBoxGetData2.Text = data.Data2;
                textBoxGetData3.Text = data.Data3;

            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void ButtonGetClear_Click(object sender, EventArgs e)
        {
            textBoxGetId.Text = string.Empty;
            textBoxGetData1.Text = string.Empty;
            textBoxGetData2.Text = string.Empty;
            textBoxGetData3.Text = string.Empty;
        }

        private void ButtonPost_Click(object sender, EventArgs e)
        {
            string address = textBoxPostAddress.Text;
            if (address.Length <= 0)
            {
                MessageBox.Show(new Form() { WindowState = FormWindowState.Maximized, TopMost = true },
                    "no input post address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SAMPLE_STRUCT data = new();
            data.Id = textBoxPostId.Text;
            data.Data1 = textBoxPostData1.Text;
            data.Data2 = textBoxPostData2.Text;
            data.Data3 = textBoxPostData3.Text;

            var task = Task.Run(() => PostSampleRestful(address, data));
            task.ContinueWith(x =>
            {
                if (x.Result)
                {
                    MessageBox.Show(new Form() { WindowState = FormWindowState.Maximized, TopMost = true },
                        "Success: Post Restful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show(new Form() { WindowState = FormWindowState.Maximized, TopMost = true },
                        "Failed: Post Restful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void ButtonPostClear_Click(object sender, EventArgs e)
        {
            textBoxPostId.Text = string.Empty;
            textBoxPostData1.Text = string.Empty;
            textBoxPostData2.Text = string.Empty;
            textBoxPostData3.Text = string.Empty;
        }
    }
}
