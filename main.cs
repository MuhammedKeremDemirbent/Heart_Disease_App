using Heart_Disease_App.ML_Model;
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
              
                var inputData = new modelInput
                {
                    gender = comboBoxgender.SelectedIndex == 1 ? 1f : 0f,
                    dataset_cleveland = comboBoxcleveland.SelectedIndex == 1 ? 1f : 0f,
                    dataset_hungary = comboBoxhungary.SelectedIndex == 1 ? 1f : 0f,
                    dataset_switzerland = comboBoxswitzerland.SelectedIndex == 1 ? 1f : 0f,

                    cp_asymptomatic = comboBoxasymptomatic.SelectedIndex == 1 ? 1f : 0f,

                    fbs_false = comboBoxfbs.SelectedIndex == 1 ? 1f : 0f,

                    restecg_lv_hypertrophy = comboBoxreslvhyper.SelectedIndex == 1 ? 1f : 0f,
                    restecg_normal = comboBoxresnormal.SelectedIndex == 1 ? 1f : 0f,

                    age = float.Parse(txtbx_age.Text, System.Globalization.CultureInfo.InvariantCulture),
                    trestbps = float.Parse(txtbx_trestbps.Text, System.Globalization.CultureInfo.InvariantCulture),
                    thalch = float.Parse(txtbx_thalch.Text, System.Globalization.CultureInfo.InvariantCulture),

                };

                string modelPath = System.IO.Path.Combine(Application.StartupPath, "ML_Model", "heart_disease_model.onnx");

                using (var session = new InferenceSession(modelPath))
                {
                    string inputName = session.InputMetadata.Keys.First();

                  
                    var inputTensor = new DenseTensor<float>(new[] { 1, 11 });

                   
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
                        var labelOutput = results.FirstOrDefault(r => r.Name == "label");
                        var labelTensor = labelOutput.Value as Tensor<long>;
                        long predictionLabel = labelTensor.GetValue(0);

                       
                        var probOutput = results.FirstOrDefault(r => r.Name == "probabilities");
                        var probTensor = probOutput.Value as Tensor<float>;

                       
                        float diseaseProbability = probTensor.GetValue(1);

                        lbl_result.Text = diseaseProbability >= 0.5f
                            ? $"✅ High Risk. (Prediction Score: %{diseaseProbability * 100:0.0})"
                            : $"❌ Low Risk. (Prediction Score: %{diseaseProbability * 100:0.0})";
                    }
                }
            }
            catch (FormatException fe)
            {
                lbl_result.Text = "ENTRY ERROR: Please ensure all entries are in the correct format (number).";
            }
            catch (Exception ex)
            {
                lbl_result.Text = $"ERROR: {ex.Message}";
            }
        }
    }
}