using Heart_Disease_App.Model;
//ONNX Runtime namespaces
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
//using System.Numerics.Tensors;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Heart_Disease_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_predict_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Giriş Verilerini Topla ve Float'a Çevir
                // ... (Bu kısım, Form1.cs kodunuzdaki gibi kalır veya GetValue metoduyla güncellenir) ...
                var inputData = new modelInput
                {
                    gender = float.Parse(txtbx_gender.Text, System.Globalization.CultureInfo.InvariantCulture),
                    dataset_cleveland = float.Parse(txtbx_dataset_cleveland.Text, System.Globalization.CultureInfo.InvariantCulture),
                    dataset_hungary = float.Parse(txtbx_dataset_hungary.Text, System.Globalization.CultureInfo.InvariantCulture),
                    dataset_switzerland = float.Parse(txtbx_dataset_switzerland.Text, System.Globalization.CultureInfo.InvariantCulture),
                    cp_asymptomatic = float.Parse(txtbx_cp_asymptomatic.Text, System.Globalization.CultureInfo.InvariantCulture),
                    fbs_false = float.Parse(txtbx_fbs_false.Text, System.Globalization.CultureInfo.InvariantCulture),
                    restecg_lv_hypertrophy = float.Parse(txtbx_restecg_lv_hypertrophy.Text, System.Globalization.CultureInfo.InvariantCulture),
                    restecg_normal = float.Parse(txtbx_restecg_normal.Text, System.Globalization.CultureInfo.InvariantCulture),
                    age = float.Parse(txtbx_age.Text, System.Globalization.CultureInfo.InvariantCulture),
                    trestbps = float.Parse(txtbx_trestbps.Text, System.Globalization.CultureInfo.InvariantCulture),
                    thalch = float.Parse(txtbx_thalch.Text, System.Globalization.CultureInfo.InvariantCulture),

                };

                string modelPath = System.IO.Path.Combine(Application.StartupPath, "Model", "heart_disease_model.onnx");

                using (var session = new InferenceSession(modelPath))
                {
                    string inputName = session.InputMetadata.Keys.First();

                  
                    var inputTensor = new DenseTensor<float>(new[] { 1, 11 });

                    // ** 9 Özellik İçin Veriyi Python Çıktı Sırasına Göre Yerleştirme **
                    inputTensor[0, 0] = inputData.gender;                     // Female
                    inputTensor[0, 1] = inputData.dataset_cleveland;          // Cleveland
                    inputTensor[0, 2] = inputData.dataset_hungary;            // Hungary
                    inputTensor[0, 3] = inputData.dataset_switzerland;        // Switzerland
                    inputTensor[0, 4] = inputData.cp_asymptomatic;            // asymptomatic
                    inputTensor[0, 5] = inputData.fbs_false;                  // FALSE
                    inputTensor[0, 6] = inputData.restecg_lv_hypertrophy;
                    inputTensor[0, 7] = inputData.restecg_normal;
                    inputTensor[0, 8] = inputData.age;
                    inputTensor[0, 9] = inputData.trestbps;
                    inputTensor[0, 10] = inputData.thalch;


                    var inputs = new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor(inputName, inputTensor)
            };

                   
                    using (var results = session.Run(inputs))
                    {
                    
                        string outputName = session.OutputMetadata.Keys.First();
                        var outputValue = results.FirstOrDefault(r => r.Name == outputName);

                        if (outputValue == null)
                        {
                            lbl_result.Text = $"KRİTİK HATA: Model çıktısı '{outputName}' bulunamadı!";
                            return;
                        }

                        float predictionValue = 0.0f;
                        bool predictionSuccess = false;

                      
                        Tensor<float> floatTensor = outputValue.Value as Tensor<float>;

                        if (floatTensor != null)
                        {
                            predictionValue = floatTensor.GetValue(0);
                            predictionSuccess = true;
                        }
                        else
                        {
                       
                            Tensor<long> longTensor = outputValue.Value as Tensor<long>;

                            if (longTensor != null)
                            {
                              
                                predictionValue = (float)longTensor.GetValue(0);
                                predictionSuccess = true;
                            }
                            else
                            {
                              
                                IEnumerable<float> floatArray = outputValue.Value as IEnumerable<float>;
                                if (floatArray != null)
                                {
                                  
                                    predictionValue = floatArray.First();
                                    predictionSuccess = true;
                                }
                            }
                        }

                        if (!predictionSuccess)
                        {
                          
                            lbl_result.Text = $"KRİTİK HATA: Model çıktı tipi hala tanınamıyor. Gerçek tip: {outputValue.Value.GetType().Name}";
                            return;
                        }

                      
                        string resultMessage = (predictionValue >= 0.5f)
                            ? $"✅ Yüksek İhtimalle Kalp Hastalığı VAR. (Skor: {predictionValue})"
                            : $"❌ Kalp Hastalığı Görülme İhtimali DÜŞÜK. (Skor: {predictionValue})";

                        lbl_result.Text = resultMessage;
                    }
                }
            }
            catch (FormatException fe)
            {
                lbl_result.Text = "GİRİŞ HATASI: Lütfen tüm girişlerin doğru formatta (sayı) olduğundan emin olun.";
            }
            catch (Exception ex)
            {
                lbl_result.Text = $"HATA: {ex.Message}";
            }
        }
    }
}