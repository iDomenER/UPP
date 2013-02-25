﻿
using System;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиСсылка
{
	///<summary>
	///Настройки формирования документов отработанного времени
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class НастройкиФормированияДокументовОтработанногоВремени:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("a8607258-159e-4f4f-a0ed-f924f31af4fe");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191629.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления {get;set;}
		public bool Предопределенный {get;set;}
		public Guid Родитель {get;set;}
		public bool ЭтоГруппа {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*100*/ Наименование {get;set;}
		public DateTime ГраницаОбработки {get;set;}//Граница обработки
		public V82.Перечисления/*Ссылка*/.Периодичность ПериодДетализации {get;set;}//Период детализации
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		public V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени СпособВводаДанных {get;set;}//Способ ввода данных
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации {get;set;}//Подразделение организации
		public bool ФормироватьДокументыАвтоматически {get;set;}//Формировать документы автоматически
		///<summary>
		///Уникальный идентификатор регламентного задания
		///</summary>
		public string/*(36)*/ РегламентноеЗадание {get;set;}//Регламентное задание
		public bool НеОбрабатыватьВсеДокументы {get;set;}//Не обрабатывать все документы
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///Количество дней после окончания периода, по истечении которых формируются документы
		///</summary>
		public decimal/*(2)*/ Задержка {get;set;}
		
		public НастройкиФормированияДокументовОтработанногоВремени()
		{
		}
		
		public НастройкиФормированияДокументовОтработанногоВремени(byte[] УникальныйИдентификатор)
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
					,_Description [Наименование]
					,_Fld2871 [ГраницаОбработки]
					,_Fld2872RRef [ПериодДетализации]
					,_Fld2873RRef [Организация]
					,_Fld2874RRef [СпособВводаДанных]
					,_Fld2875RRef [ПодразделениеОрганизации]
					,_Fld2876 [ФормироватьДокументыАвтоматически]
					,_Fld2877 [РегламентноеЗадание]
					,_Fld2878 [НеОбрабатыватьВсеДокументы]
					,_Fld2879 [Комментарий]
					,_Fld2880 [Задержка]
					From _Reference159(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор";
					Команда.Parameters.AddWithValue("УникальныйИдентификатор", УникальныйИдентификатор);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							//ToDo: Читать нужно через GetValues()
							Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Наименование = Читалка.GetString(4);
							ГраницаОбработки = Читалка.GetDateTime(5);
							ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(7));
							СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							ПодразделениеОрганизации = new V82.СправочникиСсылка.ПодразделенияОрганизаций((byte[])Читалка.GetValue(9));
							ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(10))[0]==1;
							РегламентноеЗадание = Читалка.GetString(11);
							НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(12))[0]==1;
							Комментарий = Читалка.GetString(13);
							Задержка = Читалка.GetDecimal(14);
							//return Ссылка;
						}
						else
						{
							//return null;
						}
					}
				}
			}
		}
		
		public V82.СправочникиОбъект.НастройкиФормированияДокументовОтработанногоВремени  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиФормированияДокументовОтработанногоВремени();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Родитель = Родитель;
			Объект.ЭтоГруппа = ЭтоГруппа;
			Объект.Наименование = Наименование;
			Объект.ГраницаОбработки = ГраницаОбработки;
			Объект.ПериодДетализации = ПериодДетализации;
			Объект.Организация = Организация;
			Объект.СпособВводаДанных = СпособВводаДанных;
			Объект.ПодразделениеОрганизации = ПодразделениеОрганизации;
			Объект.ФормироватьДокументыАвтоматически = ФормироватьДокументыАвтоматически;
			Объект.РегламентноеЗадание = РегламентноеЗадание;
			Объект.НеОбрабатыватьВсеДокументы = НеОбрабатыватьВсеДокументы;
			Объект.Комментарий = Комментарий;
			Объект.Задержка = Задержка;
			return Объект;
		}
		
		public void СериализацияProtoBuf(Stream Поток)
		{
			Serializer.Serialize(Поток,this);
		}
		
		public string СериализацияJson()
		{
			return this.ToJson();
		}
		
		public string СериализацияXml()
		{
			return this.ToXml();
		}
	}
}