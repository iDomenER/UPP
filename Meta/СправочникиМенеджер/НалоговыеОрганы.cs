﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	public partial class НалоговыеОрганы:СправочникМенеджер
	{
		
		public static СправочникиСсылка.НалоговыеОрганы НайтиПоКоду(string Код)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2574RRef [Вид]
					,_Fld2575 [ПолноеНаименование]
					,_Fld2576 [УчетНалогоплательщиков]
					,_Fld2577 [ПриемНалоговойОтчетности]
					,_Fld2578 [ИНН]
					,_Fld2579 [КПП]
					,_Fld2580 [Адрес]
					,_Fld2581 [Телефон]
					,_Fld2582 [АдресЭлектроннойПочты]
					,_Fld2583 [АдресСайта]
					,_Fld2584 [Комментарий]
					,_Fld2585 [УдалитьСертификат]
					,_Fld2586 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference144(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Вид = new V82.СправочникиСсылка.ВидыНалоговыхОрганов((byte[])Читалка.GetValue(6));
							Ссылка.ПолноеНаименование = Читалка.GetString(7);
							Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ИНН = Читалка.GetString(10);
							Ссылка.КПП = Читалка.GetString(11);
							Ссылка.Адрес = Читалка.GetString(12);
							Ссылка.Телефон = Читалка.GetString(13);
							Ссылка.АдресЭлектроннойПочты = Читалка.GetString(14);
							Ссылка.АдресСайта = Читалка.GetString(15);
							Ссылка.Комментарий = Читалка.GetString(16);
							Ссылка.УдалитьСертификат = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(18);
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы Выбрать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2574RRef [Вид]
					,_Fld2575 [ПолноеНаименование]
					,_Fld2576 [УчетНалогоплательщиков]
					,_Fld2577 [ПриемНалоговойОтчетности]
					,_Fld2578 [ИНН]
					,_Fld2579 [КПП]
					,_Fld2580 [Адрес]
					,_Fld2581 [Телефон]
					,_Fld2582 [АдресЭлектроннойПочты]
					,_Fld2583 [АдресСайта]
					,_Fld2584 [Комментарий]
					,_Fld2585 [УдалитьСертификат]
					,_Fld2586 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference144(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Вид = new V82.СправочникиСсылка.ВидыНалоговыхОрганов((byte[])Читалка.GetValue(6));
							Ссылка.ПолноеНаименование = Читалка.GetString(7);
							Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ИНН = Читалка.GetString(10);
							Ссылка.КПП = Читалка.GetString(11);
							Ссылка.Адрес = Читалка.GetString(12);
							Ссылка.Телефон = Читалка.GetString(13);
							Ссылка.АдресЭлектроннойПочты = Читалка.GetString(14);
							Ссылка.АдресСайта = Читалка.GetString(15);
							Ссылка.Комментарий = Читалка.GetString(16);
							Ссылка.УдалитьСертификат = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(18);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2574RRef [Вид]
					,_Fld2575 [ПолноеНаименование]
					,_Fld2576 [УчетНалогоплательщиков]
					,_Fld2577 [ПриемНалоговойОтчетности]
					,_Fld2578 [ИНН]
					,_Fld2579 [КПП]
					,_Fld2580 [Адрес]
					,_Fld2581 [Телефон]
					,_Fld2582 [АдресЭлектроннойПочты]
					,_Fld2583 [АдресСайта]
					,_Fld2584 [Комментарий]
					,_Fld2585 [УдалитьСертификат]
					,_Fld2586 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference144(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Вид = new V82.СправочникиСсылка.ВидыНалоговыхОрганов((byte[])Читалка.GetValue(6));
							Ссылка.ПолноеНаименование = Читалка.GetString(7);
							Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ИНН = Читалка.GetString(10);
							Ссылка.КПП = Читалка.GetString(11);
							Ссылка.Адрес = Читалка.GetString(12);
							Ссылка.Телефон = Читалка.GetString(13);
							Ссылка.АдресЭлектроннойПочты = Читалка.GetString(14);
							Ссылка.АдресСайта = Читалка.GetString(15);
							Ссылка.Комментарий = Читалка.GetString(16);
							Ссылка.УдалитьСертификат = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(18);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы ВыбратьПоКоду(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2574RRef [Вид]
					,_Fld2575 [ПолноеНаименование]
					,_Fld2576 [УчетНалогоплательщиков]
					,_Fld2577 [ПриемНалоговойОтчетности]
					,_Fld2578 [ИНН]
					,_Fld2579 [КПП]
					,_Fld2580 [Адрес]
					,_Fld2581 [Телефон]
					,_Fld2582 [АдресЭлектроннойПочты]
					,_Fld2583 [АдресСайта]
					,_Fld2584 [Комментарий]
					,_Fld2585 [УдалитьСертификат]
					,_Fld2586 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference144(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Вид = new V82.СправочникиСсылка.ВидыНалоговыхОрганов((byte[])Читалка.GetValue(6));
							Ссылка.ПолноеНаименование = Читалка.GetString(7);
							Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ИНН = Читалка.GetString(10);
							Ссылка.КПП = Читалка.GetString(11);
							Ссылка.Адрес = Читалка.GetString(12);
							Ссылка.Телефон = Читалка.GetString(13);
							Ссылка.АдресЭлектроннойПочты = Читалка.GetString(14);
							Ссылка.АдресСайта = Читалка.GetString(15);
							Ссылка.Комментарий = Читалка.GetString(16);
							Ссылка.УдалитьСертификат = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(18);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2574RRef [Вид]
					,_Fld2575 [ПолноеНаименование]
					,_Fld2576 [УчетНалогоплательщиков]
					,_Fld2577 [ПриемНалоговойОтчетности]
					,_Fld2578 [ИНН]
					,_Fld2579 [КПП]
					,_Fld2580 [Адрес]
					,_Fld2581 [Телефон]
					,_Fld2582 [АдресЭлектроннойПочты]
					,_Fld2583 [АдресСайта]
					,_Fld2584 [Комментарий]
					,_Fld2585 [УдалитьСертификат]
					,_Fld2586 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference144(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Вид = new V82.СправочникиСсылка.ВидыНалоговыхОрганов((byte[])Читалка.GetValue(6));
							Ссылка.ПолноеНаименование = Читалка.GetString(7);
							Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ИНН = Читалка.GetString(10);
							Ссылка.КПП = Читалка.GetString(11);
							Ссылка.Адрес = Читалка.GetString(12);
							Ссылка.Телефон = Читалка.GetString(13);
							Ссылка.АдресЭлектроннойПочты = Читалка.GetString(14);
							Ссылка.АдресСайта = Читалка.GetString(15);
							Ссылка.Комментарий = Читалка.GetString(16);
							Ссылка.УдалитьСертификат = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(18);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы СтраницаПоСсылке(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2574RRef [Вид]
					,_Fld2575 [ПолноеНаименование]
					,_Fld2576 [УчетНалогоплательщиков]
					,_Fld2577 [ПриемНалоговойОтчетности]
					,_Fld2578 [ИНН]
					,_Fld2579 [КПП]
					,_Fld2580 [Адрес]
					,_Fld2581 [Телефон]
					,_Fld2582 [АдресЭлектроннойПочты]
					,_Fld2583 [АдресСайта]
					,_Fld2584 [Комментарий]
					,_Fld2585 [УдалитьСертификат]
					,_Fld2586 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference144(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Вид = new V82.СправочникиСсылка.ВидыНалоговыхОрганов((byte[])Читалка.GetValue(6));
							Ссылка.ПолноеНаименование = Читалка.GetString(7);
							Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ИНН = Читалка.GetString(10);
							Ссылка.КПП = Читалка.GetString(11);
							Ссылка.Адрес = Читалка.GetString(12);
							Ссылка.Телефон = Читалка.GetString(13);
							Ссылка.АдресЭлектроннойПочты = Читалка.GetString(14);
							Ссылка.АдресСайта = Читалка.GetString(15);
							Ссылка.Комментарий = Читалка.GetString(16);
							Ссылка.УдалитьСертификат = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(18);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы СтраницаПоКоду(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2574RRef [Вид]
					,_Fld2575 [ПолноеНаименование]
					,_Fld2576 [УчетНалогоплательщиков]
					,_Fld2577 [ПриемНалоговойОтчетности]
					,_Fld2578 [ИНН]
					,_Fld2579 [КПП]
					,_Fld2580 [Адрес]
					,_Fld2581 [Телефон]
					,_Fld2582 [АдресЭлектроннойПочты]
					,_Fld2583 [АдресСайта]
					,_Fld2584 [Комментарий]
					,_Fld2585 [УдалитьСертификат]
					,_Fld2586 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference144(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Вид = new V82.СправочникиСсылка.ВидыНалоговыхОрганов((byte[])Читалка.GetValue(6));
							Ссылка.ПолноеНаименование = Читалка.GetString(7);
							Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ИНН = Читалка.GetString(10);
							Ссылка.КПП = Читалка.GetString(11);
							Ссылка.Адрес = Читалка.GetString(12);
							Ссылка.Телефон = Читалка.GetString(13);
							Ссылка.АдресЭлектроннойПочты = Читалка.GetString(14);
							Ссылка.АдресСайта = Читалка.GetString(15);
							Ссылка.Комментарий = Читалка.GetString(16);
							Ссылка.УдалитьСертификат = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(18);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы СтраницаПоНаименованию(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2574RRef [Вид]
					,_Fld2575 [ПолноеНаименование]
					,_Fld2576 [УчетНалогоплательщиков]
					,_Fld2577 [ПриемНалоговойОтчетности]
					,_Fld2578 [ИНН]
					,_Fld2579 [КПП]
					,_Fld2580 [Адрес]
					,_Fld2581 [Телефон]
					,_Fld2582 [АдресЭлектроннойПочты]
					,_Fld2583 [АдресСайта]
					,_Fld2584 [Комментарий]
					,_Fld2585 [УдалитьСертификат]
					,_Fld2586 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference144(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Вид = new V82.СправочникиСсылка.ВидыНалоговыхОрганов((byte[])Читалка.GetValue(6));
							Ссылка.ПолноеНаименование = Читалка.GetString(7);
							Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ИНН = Читалка.GetString(10);
							Ссылка.КПП = Читалка.GetString(11);
							Ссылка.Адрес = Читалка.GetString(12);
							Ссылка.Телефон = Читалка.GetString(13);
							Ссылка.АдресЭлектроннойПочты = Читалка.GetString(14);
							Ссылка.АдресСайта = Читалка.GetString(15);
							Ссылка.Комментарий = Читалка.GetString(16);
							Ссылка.УдалитьСертификат = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(18);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.НалоговыеОрганы СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НалоговыеОрганы();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ПолноеНаименование = "";
			Объект.ИНН = "";
			Объект.КПП = "";
			Объект.Адрес = "";
			Объект.Телефон = "";
			Объект.АдресЭлектроннойПочты = "";
			Объект.АдресСайта = "";
			Объект.Комментарий = "";
			Объект.УдалитьСертификат = "";
			Объект.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = "";
			Объект.Вид = new V82.СправочникиСсылка.ВидыНалоговыхОрганов();
			return Объект;
		}
		
		public static V82.СправочникиОбъект.НалоговыеОрганы СоздатьГруппу()
		{
			var Объект = new V82.СправочникиОбъект.НалоговыеОрганы();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ПолноеНаименование = "";
			Объект.ИНН = "";
			Объект.КПП = "";
			Объект.Адрес = "";
			Объект.Телефон = "";
			Объект.АдресЭлектроннойПочты = "";
			Объект.АдресСайта = "";
			Объект.Комментарий = "";
			Объект.УдалитьСертификат = "";
			Объект.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = "";
			Объект.Вид = new V82.СправочникиСсылка.ВидыНалоговыхОрганов();
			return Объект;
		}
	}
}