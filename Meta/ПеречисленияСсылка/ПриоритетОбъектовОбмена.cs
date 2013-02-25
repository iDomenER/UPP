﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ПриоритетОбъектовОбмена
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"246e37a8-7e0f-4d05-a6fe-a35d8056a256\", \"Представление\":\"ПриоритетПоступившегоПриОбменеОбъектаНиже\"}")]
		ПриоритетПоступившегоПриОбменеОбъектаНиже = 0,//Приоритет объекта обмена ниже
		[EnumMember(Value = "{\"Ссылка\":\"32f17ec3-d6ed-495d-80fe-8e711f461cc8\", \"Представление\":\"ПриоритетПоступившегоПриОбменеОбъектаСовпадает\"}")]
		ПриоритетПоступившегоПриОбменеОбъектаСовпадает = 1,//Приоритет объекта обмена совпадает
		[EnumMember(Value = "{\"Ссылка\":\"9b6063ec-1c58-4c13-83c5-173002b49a4a\", \"Представление\":\"ПриоритетПоступившегоПриОбменеОбъектаВыше\"}")]
		ПриоритетПоступившегоПриОбменеОбъектаВыше = 2,//Приоритет объекта обмена выше
	}
	public static partial class ПриоритетОбъектовОбмена_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПриоритетПоступившегоПриОбменеОбъектаНиже = new Guid("5da3fea6-5680-56a2-4d05-7e0f246e37a8");//Приоритет объекта обмена ниже
		public static readonly Guid ПриоритетПоступившегоПриОбменеОбъектаСовпадает = new Guid("718efe80-461f-c81c-495d-d6ed32f17ec3");//Приоритет объекта обмена совпадает
		public static readonly Guid ПриоритетПоступившегоПриОбменеОбъектаВыше = new Guid("3017c583-b402-4a9a-4c13-1c589b6063ec");//Приоритет объекта обмена выше
		public static ПриоритетОбъектовОбмена Получить(this ПриоритетОбъектовОбмена Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ПриоритетОбъектовОбмена Получить(this ПриоритетОбъектовОбмена Значение, Guid Ссылка)
		{
			if(Ссылка == ПриоритетПоступившегоПриОбменеОбъектаНиже)
			{
				return ПриоритетОбъектовОбмена.ПриоритетПоступившегоПриОбменеОбъектаНиже;
			}
			else if(Ссылка == ПриоритетПоступившегоПриОбменеОбъектаСовпадает)
			{
				return ПриоритетОбъектовОбмена.ПриоритетПоступившегоПриОбменеОбъектаСовпадает;
			}
			else if(Ссылка == ПриоритетПоступившегоПриОбменеОбъектаВыше)
			{
				return ПриоритетОбъектовОбмена.ПриоритетПоступившегоПриОбменеОбъектаВыше;
			}
			return ПриоритетОбъектовОбмена.ПустаяСсылка;
		}
		public static byte[] Ключ(this ПриоритетОбъектовОбмена Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ПриоритетОбъектовОбмена Значение)
		{
			switch (Значение)
			{
				case ПриоритетОбъектовОбмена.ПриоритетПоступившегоПриОбменеОбъектаНиже: return ПриоритетПоступившегоПриОбменеОбъектаНиже;
				case ПриоритетОбъектовОбмена.ПриоритетПоступившегоПриОбменеОбъектаСовпадает: return ПриоритетПоступившегоПриОбменеОбъектаСовпадает;
				case ПриоритетОбъектовОбмена.ПриоритетПоступившегоПриОбменеОбъектаВыше: return ПриоритетПоступившегоПриОбменеОбъектаВыше;
			}
			return Guid.Empty;
		}
	}
}