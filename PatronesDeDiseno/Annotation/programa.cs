using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Annotation
{
    public class program
    {
        public program()
        {
            var data = new suma();
            data.valorUno = 1;
            data.valorDos = 1;

            var atributos = data.GetType().GetProperties();

            foreach (var atributo in atributos)
            {
                foreach (var annotation in atributo.CustomAttributes)
                {

                    if (annotation.AttributeType.Name == "ProbandoSumaAttribute")
                    {
                        List<string> para = new List<string>();
                        foreach (var item in annotation.ConstructorArguments)
                        {
                            para.Add(item.Value.ToString());
                        }

                        Console.WriteLine(FindValores(para, data));
                    }
                }
            }

            Console.ReadKey();

        }

        public static int? FindValores(List<string> name, object obj)
        {

            Type t = obj.GetType();
            int returno = 0;
            foreach (var item in name)
            {
                PropertyInfo[] valores = t.GetProperties();

                foreach (var attr in valores)
                {
                    if (attr.Name == item)
                    {
                        var data = attr.GetValue(obj);

                        returno += int.Parse(data == null ? returno.ToString() : data.ToString());
                    }
                }
            }

            return returno;
        }

        public static void GetPropertyValues(Object obj)
        {
            Type t = obj.GetType();
            Console.WriteLine("Type is: {0}", t.Name);
            PropertyInfo[] props = t.GetProperties();
            Console.WriteLine("Properties (N = {0}):",
                              props.Length);
            foreach (var prop in props)
                if (prop.GetIndexParameters().Length == 0)
                    Console.WriteLine("   {0} ({1}): {2}", prop.Name,
                                      prop.PropertyType.Name,
                                      prop.GetValue(obj));
                else
                    Console.WriteLine("   {0} ({1}): <Indexed>", prop.Name,
                                      prop.PropertyType.Name);

        }
    }
}
