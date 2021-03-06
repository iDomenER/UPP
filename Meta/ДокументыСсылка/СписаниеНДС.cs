﻿
using System;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	///<summary>
	///Списание НДС предъявленного на расходы
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class СписаниеНДС:ДокументСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("423def30-0585-46ce-b301-e86ffdc3026f");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928012018.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public DateTime Дата {get;set;}
		public DateTime ПрефиксНомера {get;set;}
		public string/*11*/ Номер {get;set;}
		public bool Проведен {get;set;}
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете {get;set;}//Отражать в налоговом учете
		///<summary>
		///(Регл)
		///</summary>
		public object СчетСписанияНДС {get;set;}//Счет списания НДС
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДС1 {get;set;}//Субконто 1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДС2 {get;set;}//Субконто 2
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДС3 {get;set;}//Субконто 3
		public object СчетСписанияНДСНУ {get;set;}//Счет списания НДС (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДСНУ1 {get;set;}//Субконто (НУ) 1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДСНУ2 {get;set;}//Субконто (НУ) 2
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДСНУ3 {get;set;}//Субконто (НУ) 3
		
		public СписаниеНДС()
		{
		}
		
		public СписаниеНДС(byte[] УникальныйИдентификатор)
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
					,_Number [Номер]
					,_Fld22819RRef [Организация]
					,_Fld22820RRef [Ответственный]
					,_Fld22821 [Комментарий]
					,_Fld22822 [ОтражатьВНалоговомУчете]
					,_Fld22823RRef [СчетСписанияНДС]
					,_Fld22824RRef [СубконтоСписанияНДС1]
					,_Fld22825RRef [СубконтоСписанияНДС2]
					,_Fld22826RRef [СубконтоСписанияНДС3]
					,_Fld22827RRef [СчетСписанияНДСНУ]
					,_Fld22828RRef [СубконтоСписанияНДСНУ1]
					,_Fld22829RRef [СубконтоСписанияНДСНУ2]
					,_Fld22830RRef [СубконтоСписанияНДСНУ3]
					From _Document22682(NOLOCK)
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
							Номер = Читалка.GetString(3);
							Комментарий = Читалка.GetString(6);
							ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
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
		
		public V82.ДокументыОбъект.СписаниеНДС  ПолучитьОбъект()
		{
			var Объект = new V82.ДокументыОбъект.СписаниеНДС();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Номер = Номер;
			Объект.Организация = Организация;
			Объект.Ответственный = Ответственный;
			Объект.Комментарий = Комментарий;
			Объект.ОтражатьВНалоговомУчете = ОтражатьВНалоговомУчете;
			Объект.СчетСписанияНДС = СчетСписанияНДС;
			Объект.СубконтоСписанияНДС1 = СубконтоСписанияНДС1;
			Объект.СубконтоСписанияНДС2 = СубконтоСписанияНДС2;
			Объект.СубконтоСписанияНДС3 = СубконтоСписанияНДС3;
			Объект.СчетСписанияНДСНУ = СчетСписанияНДСНУ;
			Объект.СубконтоСписанияНДСНУ1 = СубконтоСписанияНДСНУ1;
			Объект.СубконтоСписанияНДСНУ2 = СубконтоСписанияНДСНУ2;
			Объект.СубконтоСписанияНДСНУ3 = СубконтоСписанияНДСНУ3;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.ДокументыСсылка.СписаниеНДС ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.ДокументыСсылка.СписаниеНДС)Кэш[УИ];
			}
			var Ссылка = new V82.ДокументыСсылка.СписаниеНДС(УникальныйИдентификатор);
			Кэш.Add(УИ, Ссылка);
			return Ссылка;
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