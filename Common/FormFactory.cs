using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appraisal_System.Common
{
    public class FormFactory<T>
    {
        //private static FrmUserManager frmUserManager;
        //private static FrmBaseManager frmBaseManager;
        //private static FrmNone frmNone;
        //private static Form form; //利用里氏替换原则，父类可以接收子类
        private static List<Form> forms = new List<Form>();
        //public static Form CreateForm(int index)
        //{
        //    HideFormAll();
        //    switch (index)
        //    {
        //        case 0:
        //            if (frmUserManager == null)
        //            {
        //                frmUserManager = new FrmUserManager();
        //                forms.Add(frmUserManager);
        //            }
        //            //frmBaseManager?.Hide();//如果不为空执行Hide()
        //            //frmUserManager.Show();
        //            form = frmUserManager;
        //            break;
        //        case 1:
        //            if (frmBaseManager == null)
        //            {
        //                frmBaseManager = new FrmBaseManager();
        //                forms.Add(frmBaseManager);
        //            }
        //            //frmUserManager?.Hide();
        //            //frmBaseManager.Show();
        //            form= frmBaseManager;
        //            break;
        //        default:
        //            if (frmNone == null)
        //            {
        //                frmNone = new FrmNone();
        //                forms.Add(frmNone);
        //            }
        //            form = frmNone;
        //            break;
        //    }
        //    return form;
        //}
        private static List<Type> types;
        static FormFactory()//缓存，反射消耗性能 静态构造函数不允许加访问修饰符
        {
            Assembly assembly = Assembly.LoadFrom("Appraisal_System.exe");//LoadFrom方法直接是根目录，不需要加path
            types = assembly.GetTypes().ToList();//.Where(m=>m.BaseType==typeof(Form)).ToArray();防止其他的类和窗体类起相同的名字//接收assembly中的所有类
        }
        public static Form CreateForm(string formName)//获取程序集
        {
            //Assembly assembly = Assembly.Load("Appraisal_System");

            //string path = AppDomain.CurrentDomain.BaseDirectory;//获取根目录

            HideFormAll();
            formName = formName == null? "FrmNone":formName;
            Form form=forms.Find(t => t.Name == formName);
            if(form == null)
            {
                Type type = types.Find(m => m.Name == formName);
                form = (Form)Activator.CreateInstance(type);
                forms.Add(form);
            }
            return form;
        } 
        public static void HideFormAll()
        {
            //frmBaseManager?.Hide();
            //frmUserManager?.Hide();
            foreach (var form in forms)
            {
                form.Hide();
            }
        }
    }
}
