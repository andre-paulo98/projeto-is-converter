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
            /*dynamic message = JsonConvert.DeserializeObject<ExpandoObject>("{'number':1000, 'str':'string', " +
                "'array1': [1,2,3,4,5,6], 'array': [{'test': 'abc', 't': 1, 'a': 55, 'b': 90}, " +
                "{'test5': 1, 't':'abc'}, {'o': 5} ]}", converter);*/
            //error 
            //dynamic message = JsonConvert.DeserializeObject<ExpandoObject>("{'array': [{'test': 'abc', 't': 1}, {'test5': 1, 't':'abc'}, {'o': 5} ]}", converter);
            //dynamic message = JsonConvert.DeserializeObject<ExpandoObject>("{'array': [ 1,2,3]}", converter);
            dynamic message = JsonConvert.DeserializeObject<ExpandoObject>("{'bookstore':{'book':[{'category':'CHILDREN','title':'Chalottes Web','author':'E.B. White','year':'1952','price':'13.60'},{'category':'WEB','title':'Beginning XML','author':'Joe Fawcett','year':'2012','price':'31.30','rate':'4'},{'category':'WEB','title':'Programming .NET Web Services','author':'Alex Ferrara','year':'2002','price':'38.36','rate':'3'}]}}", converter);
            // good 
            //dynamic message = JsonConvert.DeserializeObject<ExpandoObject>("{'number':1000,'str':'string','array':{'number2':10002,'str2':'string2','array2':'asd2','array':{'number2':10002,'str2':'string2','array2':'asd2','array3':{'number':10002,'str':'string2','array':'asd2'},'array4':{'number':10002,'str':'string2','array2':'asd2'}}}}", converter);
            //good dynamic message = JsonConvert.DeserializeObject<ExpandoObject>("{number:1000, str:'string', array: 'asd'}", converter);
            //good dynamic message = JsonConvert.DeserializeObject<List<ExpandoObject>>("[{number:1000, str:'string', array: 'asd'},{number:1000, str:'string', array: 'asd'}]", converter);


            FileHtml outputFileHtml = new FileHtml();
            outputFileHtml.output(message);
            /*
            
            var a = message[0];

            Debug.WriteLine("aa");*/
        }
    }
}
