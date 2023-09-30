using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using QuestPDF.Fluent;
using System.Windows.Forms;
using Carproject.Entities;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Carproject.PrintForms
{
    public partial class AllTrafficForm : Form
    {
        public static string BorderColor = "#E1E1E1";
        public static string NormalTextColor = "#818E94";
        public static string BlackTextColor = "#000000";
        public static int PlaceHolderWidth = 120;
        public static int LabelFontSize = 14;
        public static string Background = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources"), "A4.png");
        public static int DefaultFontSize = 14;
        public static PageSize PageSize = PageSizes.A4;
        public static int ValueFontSize = 14;
        private List<SellingContract> _contracts;

        public AllTrafficForm()
        {
            InitializeComponent();
            PopulateContracts();
        }

        public void PopulateContracts()
        {
            using var context = new ElbashacarsContext();
            _contracts = context.SellingContracts.ToList();
            foreach (var contract in _contracts)
            {
                carNumberTextBox.Items.Add(contract.CarNumber);
            }
        }

        private void restrict_button_Click(object sender, System.EventArgs e)
        {
            Print(DocumentType.SellingWithOwnership);
        }

        public static Document AnnualRenewal(PrintViewModel printViewModel)
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSize);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(DefaultFontSize));

                    page.Content()
                        .Layers(layers =>
                        {
                            layers.Layer()
                                .AlignLeft()
                                .Image(Background)
                                .FitArea()
                                .WithCompressionQuality(ImageCompressionQuality.Best);

                            layers.Layer()
                                .Column(c =>
                                {
                                    c.Item()
                                        .AlignLeft()
                                        .PaddingTop(8)
                                        .PaddingLeft(22)
                                        .Text("تجديد سنوي")
                                        .FontSize(32)
                                        .FontColor("#2F354D")
                                        .FontFamily("Cairo")
                                        .Bold();
                                });

                            layers.PrimaryLayer()
                                .Padding(16)
                                .Column(bodyHeaderColumn =>
                                {
                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .PaddingTop(75)
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text(printViewModel.CreationDate)
                                                .FontSize(14)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo")
                                                .Thin();

                                            receiptNumberRow.AutoItem()
                                                .AlignRight()
                                                .Text($"تحريرا في : ")
                                                .FontSize(14)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo")
                                                .Thin();
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .PaddingTop(-10)
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text($"السيد مدير إدارة مرور : {printViewModel.TrafficAdminstration}")
                                                .FontSize(16)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo")
                                                .Thin();
                                        });

                                    bodyHeaderColumn.Item()
                                        .PaddingTop(-10)
                                        .AlignCenter()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text($"تحية طيبة وبعد .")
                                                .FontSize(16)
                                                .FontColor("#d63344")
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text($"نود الإفادة بأنه ليس لدينا مانع من تجديد وترخيص السيارة الأتي بيانها")
                                                .FontSize(16)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text(printViewModel.SellingDate)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("تاريخ البيع :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text(printViewModel.BuyerName)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("إسم المشتري :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text(printViewModel.BuyerAddress)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("عنوان المشتري :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(row =>
                                        {
                                            row.AutoItem()
                                                .Text(printViewModel.SocialSecurityNumber)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            row.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("الرقم القومي :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });


                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(row =>
                                        {
                                            row.AutoItem()
                                            .Column(column =>
                                            {
                                                //column.Item()
                                                //    .AlignRight()
                                                //    .Row(row =>
                                                //    {
                                                //        row.AutoItem()
                                                //            .Text(printViewModel.SocialSecurityNumber)
                                                //            .FontSize(ValueFontSize)
                                                //            .FontColor(BlackTextColor)
                                                //            .FontFamily("Cairo");

                                                //        row.AutoItem()
                                                //            .Width(PlaceHolderWidth)
                                                //            .AlignRight()
                                                //            .Text("الرقم القومي :")
                                                //            .FontSize(LabelFontSize)
                                                //            .FontColor(NormalTextColor)
                                                //            .FontFamily("Cairo");
                                                //    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.TaxRegisterNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("رقم التسجيل الضريبي :")
                                                            .FontSize(13)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarType)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("نوع السيارة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarModel)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("موديل السيارة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });


                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.MotorNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("موتور رقم :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.Cargo)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("الحمولة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarVersion)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("الطراز :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text("  سم3  ")
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Text(printViewModel.LiterCapacity)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("السعة اللترية :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });
                                            });

                                            row.Spacing(50);

                                            row.AutoItem().Column(column =>
                                            {
                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CommercialNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("رقم السجل التجاري :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.PlateNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("لوحات معدنية :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarMark)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("ماركة السيارة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.ShasehNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("شاسيه رقم :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });
                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarColor)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("اللـــــــــون :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.PassengersNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("عدد الركاب :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.Shape)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("الـشـــــكـــــل :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });
                                            });



                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignCenter()
                                        .PaddingTop(10)
                                        .Row(c =>
                                        {
                                            c.AutoItem()
                                                .Text("مع بقاء حفظ الملكية لنا نحن محمد سليمان سعيد سليمان")
                                                .FontSize(16)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignCenter()
                                        .PaddingTop(-10)
                                        .Row(c =>
                                        {
                                            c.AutoItem()
                                                .Text(" ويراعى عدم تجديد الترخيص مدة أخرى أو رفع الملكية أو رفع الحظر ")
                                                .FontSize(16)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignCenter()
                                        .PaddingTop(-10)
                                        .Row(c =>
                                        {
                                            c.AutoItem()
                                                .Text("إلا بعد الرجوع إلينا أو أخذ موافقة كتابية منا")
                                                .FontSize(16)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignCenter()
                                        .Row(c => c.AutoItem()
                                            .Text("وتفضلوا سيادتكم بقبول وافر الاحترام والتقدير......")
                                            .FontSize(16)
                                            .FontColor("#d63344")
                                            .FontFamily("Cairo"));



                                    bodyHeaderColumn.Item()
                                        .AlignLeft()
                                        .Row(c =>
                                            c.AutoItem()
                                                .Width(200)
                                                .AlignRight()
                                                .Column(column =>
                                                {
                                                    column.Item()
                                                        .AlignCenter()
                                                        .Text("التوقيع")
                                                        .FontSize(16)
                                                        .FontColor(BlackTextColor)
                                                        .FontFamily("Cairo");

                                                    column.Item()
                                                        .AlignCenter()
                                                        .PaddingTop(-10)
                                                        .Text("....................................................")
                                                        .FontSize(12)
                                                        .FontColor("#d63344")
                                                        .FontFamily("Cairo");
                                                }));


                                    bodyHeaderColumn.Item()
                                        .AlignCenter()
                                        .PaddingTop(10)
                                        .Row(c =>
                                        {
                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("83403".ConvertNumbersToArabic().Invert())
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("   سجل تجاري :  ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");


                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("    منتزة ثان     ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("5 - 00728 - 171 - 00 - 09".ConvertNumbersToArabic().Invert())
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("      ملف رقم  :  ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("200 - 820 - 435".ConvertNumbersToArabic().Invert())
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("بطاقة ضريبية  :  ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");



                                        });
                                });
                        });


                });
            });
        }

        public static Document Quittance(PrintViewModel printViewModel)
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSize);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(DefaultFontSize));

                    page.Content()
                        .Layers(layers =>
                        {
                            layers.Layer()
                                .AlignLeft()
                                .Image(Background)
                                .FitArea()
                                .WithCompressionQuality(ImageCompressionQuality.Best);

                            layers.Layer()
                                .Column(c =>
                                {
                                    c.Item()
                                        .AlignLeft()
                                        .PaddingTop(8)
                                        .PaddingLeft(32)
                                        .Text("مخالصة")
                                        .FontSize(32)
                                        .FontColor("#2F354D")
                                        .FontFamily("Cairo")
                                        .Bold();
                                });

                            layers.PrimaryLayer()
                                .Padding(16)
                                .Column(bodyHeaderColumn =>
                                {
                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .PaddingTop(75)
                                        .Row(receiptNumberRow =>
                                        {
                                            //receiptNumberRow.AutoItem()
                                            //    .PaddingRight(20)
                                            //    .Text($"تحية طيبة وبعد .")
                                            //    .FontSize(16)
                                            //    .FontColor("#d63344")
                                            //    .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Text($"السيد مدير إدارة مرور : {printViewModel.TrafficAdminstration}")
                                                .FontSize(18)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo")
                                                .Thin();
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignCenter()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text($"تحية طيبة وبعد .")
                                                .FontSize(16)
                                                .FontColor("#d63344")
                                                .FontFamily("Cairo");

                                            //receiptNumberRow.AutoItem()
                                            //    .Text($"السيد مدير إدارة مرور : {printViewModel.TrafficAdminstration}")
                                            //    .FontSize(18)
                                            //    .FontColor(NormalTextColor)
                                            //    .FontFamily("Cairo")
                                            //    .Thin();
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text($"الرجاء التكرم برفع حفظ الملكية عن السيارة الأتي بيانها :-")
                                                .FontSize(18)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text(printViewModel.SellingDate)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("تاريخ البيع :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text(printViewModel.BuyerName)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("إسم المشتري :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text(printViewModel.BuyerAddress)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("عنوان المشتري :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(row =>
                                        {
                                            row.AutoItem()
                                                .Text(printViewModel.SocialSecurityNumber)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            row.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("الرقم القومي :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item().PaddingBottom(10);


                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(row =>
                                        {
                                            row.AutoItem()
                                            .Column(column =>
                                            {
                                                //column.Item()
                                                //    .AlignRight()
                                                //    .Row(row =>
                                                //    {
                                                //        row.AutoItem()
                                                //            .Text(printViewModel.SocialSecurityNumber)
                                                //            .FontSize(ValueFontSize)
                                                //            .FontColor(BlackTextColor)
                                                //            .FontFamily("Cairo");

                                                //        row.AutoItem()
                                                //            .Width(PlaceHolderWidth)
                                                //            .AlignRight()
                                                //            .Text("الرقم القومي :")
                                                //            .FontSize(LabelFontSize)
                                                //            .FontColor(NormalTextColor)
                                                //            .FontFamily("Cairo");
                                                //    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.TaxRegisterNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("رقم التسجيل الضريبي :")
                                                            .FontSize(13)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarType)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("نوع السيارة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarModel)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("موديل السيارة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });


                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.MotorNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("موتور رقم :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.Cargo)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("الحمولة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarVersion)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("الطراز :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text("  سم3  ")
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Text(printViewModel.LiterCapacity)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("السعة اللترية :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });
                                            });

                                            row.Spacing(50);

                                            row.AutoItem().Column(column =>
                                            {
                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CommercialNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("رقم السجل التجاري :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.PlateNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("لوحات معدنية :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarMark)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("ماركة السيارة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.ShasehNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("شاسيه رقم :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });
                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarColor)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("اللـــــــــون :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.PassengersNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("عدد الركاب :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.Shape)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("الـشـــــكـــــل :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });
                                            });



                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(c =>
                                        {
                                            c.AutoItem()
                                                .Text(printViewModel.CreationDate)
                                                .FontSize(16)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("تحريرا في :   ")
                                                .FontSize(16)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignCenter()
                                        .PaddingTop(20)
                                        .Row(c => c.AutoItem()
                                            .Text("وتفضلوا بقبول وافر الاحترام والتقدير......")
                                            .FontSize(16)
                                            .FontColor("#d63344")
                                            .FontFamily("Cairo"));



                                    bodyHeaderColumn.Item()
                                        .AlignLeft()
                                        .PaddingTop(20)
                                        .Row(c =>
                                            c.AutoItem()
                                                .Width(200)
                                                .AlignRight()
                                                .Column(column =>
                                                {
                                                    column.Item()
                                                        .AlignCenter()
                                                        .Text("التوقيع")
                                                        .FontSize(16)
                                                        .FontColor(BlackTextColor)
                                                        .FontFamily("Cairo");

                                                    column.Item()
                                                        .AlignCenter()
                                                        .Text("....................................................")
                                                        .FontSize(12)
                                                        .FontColor("#d63344")
                                                        .FontFamily("Cairo");
                                                }));


                                    bodyHeaderColumn.Item()
                                        .AlignCenter()
                                        .PaddingTop(20)
                                        .Row(c =>
                                        {
                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("83403".ConvertNumbersToArabic().Invert())
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("   سجل تجاري :  ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");


                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("    منتزة ثان     ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("5 - 00728 - 171 - 00 - 09".ConvertNumbersToArabic().Invert())
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("      ملف رقم  :  ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("200 - 820 - 435".ConvertNumbersToArabic().Invert())
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("بطاقة ضريبية  :  ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");



                                        });
                                });
                        });


                });
            });
        }

        public static Document SellingWithReservingOwnership(PrintViewModel printViewModel)
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSize);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(DefaultFontSize));

                    page.Content()
                        .Layers(layers =>
                        {
                            layers.Layer()
                                .AlignLeft()
                                .Image(Background)
                                .FitArea()
                                .WithCompressionQuality(ImageCompressionQuality.Best);

                            layers.Layer()
                                .Column(c =>
                                {
                                    c.Item()
                                        .AlignLeft()
                                        .PaddingTop(28)
                                        .PaddingLeft(28)
                                        .Text("مبايعة مع حفظ الملكية")
                                        .FontSize(16)
                                        .FontColor("#2F354D")
                                        .FontFamily("Cairo")
                                        .Bold();
                                });

                            layers.PrimaryLayer()
                                .Padding(16)
                                .Column(bodyHeaderColumn =>
                                {
                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .PaddingTop(75)
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .PaddingRight(20)
                                                .Text($"تحية طيبة وبعد .")
                                                .FontSize(16)
                                                .FontColor("#d63344")
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .PaddingLeft(50)
                                                .Text($"السيد مدير إدارة مرور : {printViewModel.TrafficAdminstration}")
                                                .FontSize(14)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo")
                                                .Thin();
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            //receiptNumberRow.AutoItem()
                                            //    .PaddingRight(20)
                                            //    .Text(printViewModel.SellingBillNumber)
                                            //    .FontSize(16)
                                            //    .FontColor(BlackTextColor)
                                            //    .FontFamily("Cairo")
                                            //    .Thin();

                                            receiptNumberRow.AutoItem()
                                                .PaddingRight(20)
                                                .Text($"فاتورة بيع رقم : ")
                                                .FontSize(14)
                                                .FontColor("#818E94")
                                                .FontFamily("Cairo")
                                                .Thin();

                                            receiptNumberRow.AutoItem()
                                                .PaddingLeft(80)
                                                .Text($"({printViewModel.TrafficNumber})")
                                                .FontSize(18)
                                                .FontColor("#d63344")
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Text($"إعتمادا بمرور إسكندرية رقم ")
                                                .FontSize(18)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                      .AlignRight()
                                      .PaddingTop(10)
                                      .Row(receiptNumberRow =>
                                      {

                                          //receiptNumberRow.AutoItem()
                                          //    .Text(printViewModel.TrafficLeader)
                                          //    .FontSize(ValueFontSize)
                                          //    .FontColor(BlackTextColor)
                                          //    .FontFamily("Cairo");

                                          receiptNumberRow.AutoItem()
                                              .AlignRight()
                                              .Text("نحيط سيادتكم علما بإننا قد بعنا السيارة الأتي بيانها :-")
                                              .FontSize(LabelFontSize)
                                              .FontColor(NormalTextColor)
                                              .FontFamily("Cairo");
                                      });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text(printViewModel.SellingDate)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("تاريخ البيع :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text(printViewModel.BuyerName)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("إسم المشتري :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text(printViewModel.BuyerAddress)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("عنوان المشتري :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(row =>
                                        {
                                            row.AutoItem()
                                                .Text(printViewModel.SocialSecurityNumber)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            row.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("الرقم القومي :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item().PaddingBottom(10);


                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(row =>
                                        {
                                            row.AutoItem()
                                            .Column(column =>
                                            {
                                                //column.Item()
                                                //    .AlignRight()
                                                //    .Row(row =>
                                                //    {
                                                //        row.AutoItem()
                                                //            .Text(printViewModel.SocialSecurityNumber)
                                                //            .FontSize(ValueFontSize)
                                                //            .FontColor(BlackTextColor)
                                                //            .FontFamily("Cairo");

                                                //        row.AutoItem()
                                                //            .Width(PlaceHolderWidth)
                                                //            .AlignRight()
                                                //            .Text("الرقم القومي :")
                                                //            .FontSize(LabelFontSize)
                                                //            .FontColor(NormalTextColor)
                                                //            .FontFamily("Cairo");
                                                //    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.TaxRegisterNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("رقم التسجيل الضريبي :")
                                                            .FontSize(13)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarType)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("نوع السيارة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarModel)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("موديل السيارة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });


                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.MotorNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("موتور رقم :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.Cargo)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("الحمولة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarVersion)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("الطراز :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text("  سم3  ")
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Text(printViewModel.LiterCapacity)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("السعة اللترية :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });
                                            });

                                            row.Spacing(50);

                                            row.AutoItem().Column(column =>
                                            {
                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CommercialNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("رقم السجل التجاري :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.PlateNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("لوحات معدنية :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarMark)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("ماركة السيارة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.ShasehNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("شاسيه رقم :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });
                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarColor)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("اللـــــــــون :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.PassengersNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("عدد الركاب :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.Shape)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("الـشـــــكـــــل :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });
                                            });



                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignCenter()
                                        .Row(c => c.AutoItem()
                                            .Text("مع حق حفظ الملكية للصفوة لتجارة السيارات")
                                            .FontSize(20)
                                            .FontColor("#d63344")
                                            .FontFamily("Cairo"));

                                    bodyHeaderColumn.Item()
                                        .AlignCenter()
                                        .PaddingTop(10)
                                        .Row(c => c.AutoItem()
                                            .Text("وتفضلوا بقبول وافر الاحترام والتقدير......")
                                            .FontSize(16)
                                            .FontColor("#d63344")
                                            .FontFamily("Cairo"));



                                    bodyHeaderColumn.Item()
                                        .AlignLeft()
                                        .PaddingTop(20)
                                        .Row(c =>
                                            c.AutoItem()
                                                .Width(200)
                                                .AlignRight()
                                                .Column(column =>
                                                {
                                                    column.Item()
                                                        .AlignCenter()
                                                        .Text("التوقيع")
                                                        .FontSize(16)
                                                        .FontColor(BlackTextColor)
                                                        .FontFamily("Cairo");

                                                    column.Item()
                                                        .AlignCenter()
                                                        .Text("....................................................")
                                                        .FontSize(12)
                                                        .FontColor("#d63344")
                                                        .FontFamily("Cairo");
                                                }));


                                    bodyHeaderColumn.Item()
                                        .AlignCenter()
                                        .PaddingTop(20)
                                        .Row(c =>
                                        {
                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("83403".ConvertNumbersToArabic().Invert())
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("   سجل تجاري :  ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");


                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("    منتزة ثان     ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("5 - 00728 - 171 - 00 - 09".ConvertNumbersToArabic().Invert())
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("      ملف رقم  :  ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("200 - 820 - 435".ConvertNumbersToArabic().Invert())
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("بطاقة ضريبية  :  ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");



                                        });
                                });
                        });


                });
            });
        }

        public static Document CreateSellingDocumentInCash(PrintViewModel printViewModel)
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSize);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(DefaultFontSize));

                    page.Content()
                        .Layers(layers =>
                        {
                            layers.Layer()
                                .AlignLeft()
                                .Image(Background)
                                .FitArea()
                                .WithCompressionQuality(ImageCompressionQuality.Best);

                            layers.Layer()
                                .Column(c =>
                                {
                                    c.Item()
                                        .AlignLeft()
                                        .PaddingTop(8)
                                        .PaddingLeft(32)
                                        .Text("مبايعة نقدا")
                                        .FontSize(32)
                                        .FontColor("#2F354D")
                                        .FontFamily("Cairo")
                                        .Bold();
                                });

                            layers.PrimaryLayer()
                                .Padding(16)
                                .Column(bodyHeaderColumn =>
                                {
                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .PaddingTop(75)
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .PaddingRight(20)
                                                .Text($"تحية طيبة وبعد .")
                                                .FontSize(16)
                                                .FontColor("#d63344")
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .PaddingLeft(50)
                                                .Text($"السيد مدير إدارة مرور : {printViewModel.TrafficAdminstration}")
                                                .FontSize(14)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo")
                                                .Thin();
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            //receiptNumberRow.AutoItem()
                                            //    .PaddingRight(20)
                                            //    .Text(printViewModel.SellingBillNumber)
                                            //    .FontSize(16)
                                            //    .FontColor(BlackTextColor)
                                            //    .FontFamily("Cairo")
                                            //    .Thin();

                                            receiptNumberRow.AutoItem()
                                                .PaddingRight(20)
                                                .Text($"فاتورة بيع رقم : ")
                                                .FontSize(14)
                                                .FontColor("#818E94")
                                                .FontFamily("Cairo")
                                                .Thin();

                                            receiptNumberRow.AutoItem()
                                                .PaddingLeft(80)
                                                .Text($"({printViewModel.TrafficNumber})")
                                                .FontSize(18)
                                                .FontColor("#d63344")
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Text($"إعتمادا بمرور إسكندرية رقم ")
                                                .FontSize(18)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                      .AlignRight()
                                      .PaddingTop(10)
                                      .Row(receiptNumberRow =>
                                      {

                                          //receiptNumberRow.AutoItem()
                                          //    .Text(printViewModel.TrafficLeader)
                                          //    .FontSize(ValueFontSize)
                                          //    .FontColor(BlackTextColor)
                                          //    .FontFamily("Cairo");

                                          receiptNumberRow.AutoItem()
                                              .AlignRight()
                                              .Text("نحيط سيادتكم علما بإننا قد بعنا السيارة الأتي بيانها :-")
                                              .FontSize(LabelFontSize)
                                              .FontColor(NormalTextColor)
                                              .FontFamily("Cairo");
                                      });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text(printViewModel.SellingDate)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("تاريخ البيع :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text(printViewModel.BuyerName)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("إسم المشتري :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(receiptNumberRow =>
                                        {
                                            receiptNumberRow.AutoItem()
                                                .Text(printViewModel.BuyerAddress)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            receiptNumberRow.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("عنوان المشتري :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(row =>
                                        {
                                            row.AutoItem()
                                                .Text(printViewModel.SocialSecurityNumber)
                                                .FontSize(ValueFontSize)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            row.AutoItem()
                                                .Width(PlaceHolderWidth)
                                                .AlignRight()
                                                .Text("الرقم القومي :")
                                                .FontSize(LabelFontSize)
                                                .FontColor(NormalTextColor)
                                                .FontFamily("Cairo");
                                        });

                                    bodyHeaderColumn.Item().PaddingBottom(10);


                                    bodyHeaderColumn.Item()
                                        .AlignRight()
                                        .Row(row =>
                                        {
                                            row.AutoItem()
                                            .Column(column =>
                                            {
                                                //column.Item()
                                                //    .AlignRight()
                                                //    .Row(row =>
                                                //    {
                                                //        row.AutoItem()
                                                //            .Text(printViewModel.SocialSecurityNumber)
                                                //            .FontSize(ValueFontSize)
                                                //            .FontColor(BlackTextColor)
                                                //            .FontFamily("Cairo");

                                                //        row.AutoItem()
                                                //            .Width(PlaceHolderWidth)
                                                //            .AlignRight()
                                                //            .Text("الرقم القومي :")
                                                //            .FontSize(LabelFontSize)
                                                //            .FontColor(NormalTextColor)
                                                //            .FontFamily("Cairo");
                                                //    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.TaxRegisterNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("رقم التسجيل الضريبي :")
                                                            .FontSize(13)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarType)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("نوع السيارة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarModel)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("موديل السيارة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });


                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.MotorNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("موتور رقم :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.Cargo)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("الحمولة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarVersion)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("الطراز :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text("  سم3  ")
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Text(printViewModel.LiterCapacity)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("السعة اللترية :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });
                                            });

                                            row.Spacing(50);

                                            row.AutoItem().Column(column =>
                                            {
                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CommercialNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("رقم السجل التجاري :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.PlateNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("لوحات معدنية :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarMark)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("ماركة السيارة :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.ShasehNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("شاسيه رقم :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });
                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.CarColor)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("اللـــــــــون :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.PassengersNumber)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("عدد الركاب :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });

                                                column.Item()
                                                    .AlignRight()
                                                    .Row(row =>
                                                    {
                                                        row.AutoItem()
                                                            .Text(printViewModel.Shape)
                                                            .FontSize(ValueFontSize)
                                                            .FontColor(BlackTextColor)
                                                            .FontFamily("Cairo");

                                                        row.AutoItem()
                                                            .Width(PlaceHolderWidth)
                                                            .AlignRight()
                                                            .Text("الـشـــــكـــــل :")
                                                            .FontSize(LabelFontSize)
                                                            .FontColor(NormalTextColor)
                                                            .FontFamily("Cairo");
                                                    });
                                            });



                                        });

                                    bodyHeaderColumn.Item()
                                        .AlignCenter()
                                        .PaddingTop(20)
                                        .Row(c => c.AutoItem()
                                            .Text("وتفضلوا بقبول وافر الاحترام والتقدير......")
                                            .FontSize(16)
                                            .FontColor("#d63344")
                                            .FontFamily("Cairo"));



                                    bodyHeaderColumn.Item()
                                        .AlignLeft()
                                        .PaddingTop(20)
                                        .Row(c =>
                                            c.AutoItem()
                                                .Width(200)
                                                .AlignRight()
                                                .Column(column =>
                                                {
                                                    column.Item()
                                                        .AlignCenter()
                                                        .Text("التوقيع")
                                                        .FontSize(16)
                                                        .FontColor(BlackTextColor)
                                                        .FontFamily("Cairo");

                                                    column.Item()
                                                        .AlignCenter()
                                                        .Text("....................................................")
                                                        .FontSize(12)
                                                        .FontColor("#d63344")
                                                        .FontFamily("Cairo");
                                                }));


                                    bodyHeaderColumn.Item()
                                        .AlignCenter()
                                        .PaddingTop(20)
                                        .Row(c =>
                                        {
                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("83403".ConvertNumbersToArabic().Invert())
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("   سجل تجاري :  ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");


                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("    منتزة ثان     ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("5 - 00728 - 171 - 00 - 09".ConvertNumbersToArabic().Invert())
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("      ملف رقم  :  ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("200 - 820 - 435".ConvertNumbersToArabic().Invert())
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");

                                            c.AutoItem()
                                                .AlignRight()
                                                .Text("بطاقة ضريبية  :  ")
                                                .FontSize(12)
                                                .FontColor(BlackTextColor)
                                                .FontFamily("Cairo");



                                        });
                                });
                        });


                });
            });
        }



        public void Print(DocumentType documentType)
        {
            var printViewModel = new PrintViewModel()
            {
                BuyerName = buyerNameTextBox.Text,
                CreationDate = creationDateTextBox.Text,
                CarColor = colorTextBox.Text,
                BuyerAddress = buyerAddressTextBox.Text,
                CarMark = carMarkTextBox.Text,
                CarModel = modelTextBox.Text,
                CarType = carTypeTextBox.Text,
                CarVersion = carVersionTextBox.Text,
                Cargo = cargoTextBox.Text,
                CommercialNumber = "65464664645",
                LiterCapacity = capacityTextBox.Text,
                PlateNumber = carNumberTextBox.Text,
                SellingDate = sellingDateTextBox.Text,
                Shape = shapeTextBox.Text,
                TaxRegisterNumber = "646546321654",
                ShasehNumber = shasehTextBox.Text,
                TrafficAdminstration = trafficTextBox.Text,
                MotorNumber = motorTextBox.Text,
                PassengersNumber = passangersTextBox.Text,
                SocialSecurityNumber = nationalIdTextBox.Text,
                TrafficNumber = "118",
            };

            IDocument document = null;

            switch (documentType)
            {
                case DocumentType.Selling:
                    document = CreateSellingDocumentInCash(printViewModel);
                    break;
                case DocumentType.SellingWithOwnership:
                    document = SellingWithReservingOwnership(printViewModel);
                    break;
                case DocumentType.Quittance:
                    document = Quittance(printViewModel);
                    break;
                case DocumentType.AnnualRenewal:
                    document = AnnualRenewal(printViewModel);
                    break;
            }

            if (document != null)
            {
                document.GeneratePdfAndShow();
            }
        }

        private void groupBox3_Enter(object sender, System.EventArgs e)
        {

        }

        private void AllTrafficForm_Load(object sender, System.EventArgs e)
        {

        }

        private void selling_button_Click(object sender, EventArgs e)
        {
            Print(DocumentType.Selling);
        }

        private void finishing_button_Click(object sender, EventArgs e)
        {
            Print(DocumentType.Quittance);
        }

        private void renewal_button_Click(object sender, EventArgs e)
        {
            Print(DocumentType.AnnualRenewal);
        }

        private void carNumberTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var carNumber = carNumberTextBox.Items[carNumberTextBox.SelectedIndex].ToString();
            var contract = _contracts.FirstOrDefault(c => c.CarNumber == carNumber);
            if (contract == null)
                return;

            modelTextBox.Text = contract.CarModel;
            shasehTextBox.Text = contract.CarShaseh;
            colorTextBox.Text = contract.CarColor;
            carMarkTextBox.Text = contract.CarMark;
            carTypeTextBox.Text = contract.CarKind;
            motorTextBox.Text = contract.CarMotor;
            carVersionTextBox.Text = contract.CarMark;
            shapeTextBox.Text = contract.CarShape;
            buyerNameTextBox.Text = contract.BuyerName;
            buyerAddressTextBox.Text = contract.BuyerAddress;
            nationalIdTextBox.Text = contract.BuyerCard;
            sellingDateTextBox.Text = contract.CreatedDate?.ToString("d");
        }

        private void AllTrafficForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}



