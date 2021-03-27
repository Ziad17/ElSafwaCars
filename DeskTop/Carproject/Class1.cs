using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carproject
{
    class Class1
    {
        public static void main(string[] args)
        {

            string firstTerm = "يقر البائع بأن السيارة المذكورة بعاليه ملكه وليس عليها أي ديون أو أقساط أو قرارات أو رسوم جمركية وحجوزات تعوق نقل ملكيتها للمشتري";
            string secondTerm = "يقر البائع بأن جميع البيانات الواردة بهذه السيارة صحيحة وعلى مسؤليته الشخصية";
            string thirdTerm = "يقر البائع بأنه مسئول عن سيارته حتى تحرير عقد البيع من مخالفات وضرائب وحوادث وما شبه ذلك دون أدنى مسؤلية على المشتري";
            string forthTerm = "يلتزم البائع بتسليم المشتري ساعة التوثيق شهادةالمخالفات والبيانات الخاصة بالسيارة محل هذا العقد";
            string fifthTerm = "يقر المشتري بأنه عاين السيارة المعاينة التامة النافية للجهالة وقبلها بحالتها التي عليها وأصبح مسؤلا عنها مع ملاحظة أن لقلم المرور المختص الحق في مطالبته بكل ما يترتب على السيارة دون الرجوع إلى المالك الأصلي إبتداء من وقت إستلامها ";
            string sixthTerm = "";
            string seventhTerm = "";
            string eighthTerm = "بعد مرور 24 ساعة من توقيع هذا العقد ليس لأي من الطرفين الحق في التراجع";
            string ninethTerm = "أن كانت السيارة نمر استغنى أو مسروقة أو مسلمة تلزم الباثع بالشرط الجزائي";
            string tenthTerm = "";// check if it's off or not 
            string elevenTerm = "";
            string twelveTerm = "لا يحق للمشتري مطالبة البائع بأي إلتزامات مادية بعد هذا التاريخ وكذلك لا يعتبره مدنيا ولا جنائيا";
            string threeteenTerm = "";


            string line1_1 = "أنه في يوم الموافق: ";
            string line1_2 = "الساعة: ";
            string first_line = String.Format(line1_1 + "{0}" + "\n" + line1_2 + "{1}", "22/2/2033", "52/22");
            Font headerFont = new Font("Times New Roman", 22, FontStyle.Bold);
            Font builtInFont = new Font("Times New Roman", 16, FontStyle.Regular);
            //         Font filledInFont = new Font();
            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            Console.WriteLine(first_line);
            
                
                
        }
    }
}
