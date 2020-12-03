using DataSourcesConverter.Components.Output.FileHtmlOutput;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourcesConverter {
    public partial class FormHome : Form {
        public FormHome() {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e) {
            var converter = new ExpandoObjectConverter();
            dynamic message = JsonConvert.DeserializeObject<ExpandoObject>("{'number':1000, 'str':'string', 'array1': [1,2,3,4,5,6], 'array': [{'test': 'abc', 't': 1, 'a': 55, 'b': 90}, {'test5': 1, 't':'abc'}, {'o': 5} ]}", converter);
            //dynamic message = JsonConvert.DeserializeObject<ExpandoObject>("{'array': [{'test': 'abc', 't': 1}, {'test5': 1, 't':'abc'}, {'o': 5} ]}", converter);
            //dynamic message = JsonConvert.DeserializeObject<ExpandoObject>("{number:1000, str:'string', array: [1,2,3,4,5,6]}", converter);
            //dynamic message = JsonConvert.DeserializeObject<ExpandoObject>("{number:1000, str:'string', array: 'asd'}", converter);


            FileHtml outputFileHtml = new FileHtml();
            outputFileHtml.output(message);
            /*
            
            var a = message[0];

            Debug.WriteLine("aa");*/
        }
    }
}
