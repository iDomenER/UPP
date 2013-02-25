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
	///<summary>
	///Хранилище дополнительной информации
	///</summary>
	public partial class ХранилищеДополнительнойИнформации:СправочникМенеджер
	{
		
		public static СправочникиВыборка.ХранилищеДополнительнойИнформации Выбрать()
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
					,_Description [Наименование]
					,_Fld4215RRef [ВидДанных]
					,_Fld4216 [ИмяФайла]
					,_Fld4217_TYPE [Объект_Тип],_Fld4217_RRRef [Объект],_Fld4217_RTRef [Объект_Вид]
					,_Fld4218 [Хранилище]
					,_Fld4219 [ТекстФайла]
					From _Reference288(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ХранилищеДополнительнойИнформации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ХранилищеДополнительнойИнформации();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ВидДанных = V82.Перечисления/*Ссылка*/.ВидыДополнительнойИнформацииОбъектов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.ИмяФайла = Читалка.GetString(6);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ХранилищеДополнительнойИнформации ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Description [Наименование]
					,_Fld4215RRef [ВидДанных]
					,_Fld4216 [ИмяФайла]
					,_Fld4217_TYPE [Объект_Тип],_Fld4217_RRRef [Объект],_Fld4217_RTRef [Объект_Вид]
					,_Fld4218 [Хранилище]
					,_Fld4219 [ТекстФайла]
					From _Reference288(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ХранилищеДополнительнойИнформации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ХранилищеДополнительнойИнформации();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ВидДанных = V82.Перечисления/*Ссылка*/.ВидыДополнительнойИнформацииОбъектов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.ИмяФайла = Читалка.GetString(6);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ХранилищеДополнительнойИнформации ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Description [Наименование]
					,_Fld4215RRef [ВидДанных]
					,_Fld4216 [ИмяФайла]
					,_Fld4217_TYPE [Объект_Тип],_Fld4217_RRRef [Объект],_Fld4217_RTRef [Объект_Вид]
					,_Fld4218 [Хранилище]
					,_Fld4219 [ТекстФайла]
					From _Reference288(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ХранилищеДополнительнойИнформации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ХранилищеДополнительнойИнформации();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ВидДанных = V82.Перечисления/*Ссылка*/.ВидыДополнительнойИнформацииОбъектов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.ИмяФайла = Читалка.GetString(6);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ХранилищеДополнительнойИнформации СтраницаПоСсылке(int Размер,int Номер)
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
					,_Description [Наименование]
					,_Fld4215RRef [ВидДанных]
					,_Fld4216 [ИмяФайла]
					,_Fld4217_TYPE [Объект_Тип],_Fld4217_RRRef [Объект],_Fld4217_RTRef [Объект_Вид]
					,_Fld4218 [Хранилище]
					,_Fld4219 [ТекстФайла]
					From _Reference288(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ХранилищеДополнительнойИнформации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ХранилищеДополнительнойИнформации();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ВидДанных = V82.Перечисления/*Ссылка*/.ВидыДополнительнойИнформацииОбъектов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.ИмяФайла = Читалка.GetString(6);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ХранилищеДополнительнойИнформации СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Description [Наименование]
					,_Fld4215RRef [ВидДанных]
					,_Fld4216 [ИмяФайла]
					,_Fld4217_TYPE [Объект_Тип],_Fld4217_RRRef [Объект],_Fld4217_RTRef [Объект_Вид]
					,_Fld4218 [Хранилище]
					,_Fld4219 [ТекстФайла]
					From _Reference288(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ХранилищеДополнительнойИнформации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ХранилищеДополнительнойИнформации();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ВидДанных = V82.Перечисления/*Ссылка*/.ВидыДополнительнойИнформацииОбъектов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.ИмяФайла = Читалка.GetString(6);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.ХранилищеДополнительнойИнформации СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ХранилищеДополнительнойИнформации();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ИмяФайла = "";
			Объект.ВидДанных = V82.Перечисления/*Ссылка*/.ВидыДополнительнойИнформацииОбъектов.ПустаяСсылка;
			return Объект;
		}
	}
}