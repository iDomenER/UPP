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
	[ProtoContract]
	[DataContract]
	public partial class НастройкиАналитикиУчета:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("499ec507-a418-47ff-8f7e-37d01c34e0f5");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221190709.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*25*/ Код {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*50*/ Наименование {get;set;}
		public bool УправленческийУчет {get;set;}//Управленческий учет
		public bool РегламентированныйУчет {get;set;}//Регламентированный учет
		public object ЗначениеПоУмолчанию {get;set;}//Значение по умолчанию
		public bool ТолькоПросмотр {get;set;}//Только просмотр
		public bool ТолькоПросмотрРегл {get;set;}//Только просмотр регл.
		
		public НастройкиАналитикиУчета()
		{
		}
		
		public НастройкиАналитикиУчета(byte[] УникальныйИдентификатор)
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
					,_Fld2641 [УправленческийУчет]
					,_Fld2642 [РегламентированныйУчет]
					,_Fld2643_TYPE [ЗначениеПоУмолчанию_Тип],_Fld2643_RRRef [ЗначениеПоУмолчанию],_Fld2643_RTRef [ЗначениеПоУмолчанию_Вид]
					,_Fld2644 [ТолькоПросмотр]
					,_Fld2645 [ТолькоПросмотрРегл]
					From _Reference148(NOLOCK)
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
							Код = Читалка.GetString(4);
							Наименование = Читалка.GetString(5);
							УправленческийУчет = ((byte[])Читалка.GetValue(6))[0]==1;
							РегламентированныйУчет = ((byte[])Читалка.GetValue(7))[0]==1;
							ТолькоПросмотр = ((byte[])Читалка.GetValue(11))[0]==1;
							ТолькоПросмотрРегл = ((byte[])Читалка.GetValue(12))[0]==1;
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
		
		public V82.СправочникиОбъект.НастройкиАналитикиУчета  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиАналитикиУчета();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Родитель = Родитель;
			Объект.ЭтоГруппа = ЭтоГруппа;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.УправленческийУчет = УправленческийУчет;
			Объект.РегламентированныйУчет = РегламентированныйУчет;
			Объект.ЗначениеПоУмолчанию = ЗначениеПоУмолчанию;
			Объект.ТолькоПросмотр = ТолькоПросмотр;
			Объект.ТолькоПросмотрРегл = ТолькоПросмотрРегл;
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