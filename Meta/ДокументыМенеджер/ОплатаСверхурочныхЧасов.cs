﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.ДокументыСсылка;
using V82.Документы;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Документы//Менеджер
{
	///<summary>
	///(Регл)
	///</summary>
	public partial class ОплатаСверхурочныхЧасов:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ОплатаСверхурочныхЧасов НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld6763 [ПериодРегистрации]
					,_Fld6764RRef [Организация]
					,_Fld6765 [Комментарий]
					,_Fld6766RRef [Ответственный]
					,_Fld6767 [КраткийСоставДокумента]
					,_Fld6768RRef [ПерерассчитываемыйДокумент]
					From _Document338(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ОплатаСверхурочныхЧасов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ПерерассчитываемыйДокумент = V82.ДокументыСсылка.ОплатаСверхурочныхЧасов.ВзятьИзКэша((byte[])Читалка.GetValue(8));
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
		
		public static ДокументыСсылка.ОплатаСверхурочныхЧасов НайтиПоНомеру(string Номер)
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
					,_Fld6763 [ПериодРегистрации]
					,_Fld6764RRef [Организация]
					,_Fld6765 [Комментарий]
					,_Fld6766RRef [Ответственный]
					,_Fld6767 [КраткийСоставДокумента]
					,_Fld6768RRef [ПерерассчитываемыйДокумент]
					From _Document338(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ОплатаСверхурочныхЧасов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ПерерассчитываемыйДокумент = V82.ДокументыСсылка.ОплатаСверхурочныхЧасов.ВзятьИзКэша((byte[])Читалка.GetValue(8));
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
		
		public static ДокументыВыборка.ОплатаСверхурочныхЧасов Выбрать()
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
					,_Fld6763 [ПериодРегистрации]
					,_Fld6764RRef [Организация]
					,_Fld6765 [Комментарий]
					,_Fld6766RRef [Ответственный]
					,_Fld6767 [КраткийСоставДокумента]
					,_Fld6768RRef [ПерерассчитываемыйДокумент]
					From _Document338(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ОплатаСверхурочныхЧасов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ОплатаСверхурочныхЧасов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ПерерассчитываемыйДокумент = V82.ДокументыСсылка.ОплатаСверхурочныхЧасов.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ОплатаСверхурочныхЧасов ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld6763 [ПериодРегистрации]
					,_Fld6764RRef [Организация]
					,_Fld6765 [Комментарий]
					,_Fld6766RRef [Ответственный]
					,_Fld6767 [КраткийСоставДокумента]
					,_Fld6768RRef [ПерерассчитываемыйДокумент]
					From _Document338(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ОплатаСверхурочныхЧасов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ОплатаСверхурочныхЧасов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ПерерассчитываемыйДокумент = V82.ДокументыСсылка.ОплатаСверхурочныхЧасов.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ОплатаСверхурочныхЧасов ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld6763 [ПериодРегистрации]
					,_Fld6764RRef [Организация]
					,_Fld6765 [Комментарий]
					,_Fld6766RRef [Ответственный]
					,_Fld6767 [КраткийСоставДокумента]
					,_Fld6768RRef [ПерерассчитываемыйДокумент]
					From _Document338(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ОплатаСверхурочныхЧасов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ОплатаСверхурочныхЧасов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ПерерассчитываемыйДокумент = V82.ДокументыСсылка.ОплатаСверхурочныхЧасов.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ОплатаСверхурочныхЧасов СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld6763 [ПериодРегистрации]
					,_Fld6764RRef [Организация]
					,_Fld6765 [Комментарий]
					,_Fld6766RRef [Ответственный]
					,_Fld6767 [КраткийСоставДокумента]
					,_Fld6768RRef [ПерерассчитываемыйДокумент]
					From _Document338(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ОплатаСверхурочныхЧасов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ОплатаСверхурочныхЧасов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ПерерассчитываемыйДокумент = V82.ДокументыСсылка.ОплатаСверхурочныхЧасов.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ОплатаСверхурочныхЧасов СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld6763 [ПериодРегистрации]
					,_Fld6764RRef [Организация]
					,_Fld6765 [Комментарий]
					,_Fld6766RRef [Ответственный]
					,_Fld6767 [КраткийСоставДокумента]
					,_Fld6768RRef [ПерерассчитываемыйДокумент]
					From _Document338(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ОплатаСверхурочныхЧасов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ОплатаСверхурочныхЧасов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ПерерассчитываемыйДокумент = V82.ДокументыСсылка.ОплатаСверхурочныхЧасов.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ОплатаСверхурочныхЧасов СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ОплатаСверхурочныхЧасов();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.КраткийСоставДокумента = "";
			Объект.ПерерассчитываемыйДокумент = new V82.ДокументыСсылка.ОплатаСверхурочныхЧасов();
			return Объект;
		}
	}
}