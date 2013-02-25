﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ОсобенностиИсчисленияНДФЛ
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"c381f54f-58a6-4bae-933c-967c283c4605\", \"Представление\":\"СтандартныеВычетыНарастающимИтогом\"}")]
		СтандартныеВычетыНарастающимИтогом = 0,//Стандартные вычеты применяются нарастающим итогом в течение налогового периода
		[EnumMember(Value = "{\"Ссылка\":\"263c2861-ef69-43a3-b9a1-5745895e37c8\", \"Представление\":\"СтандартныеВычетыВПределахМесячногоДохода\"}")]
		СтандартныеВычетыВПределахМесячногоДохода = 1,//Стандартные вычеты применяются в пределах месячного дохода налогоплательщика
	}
	public static partial class ОсобенностиИсчисленияНДФЛ_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid СтандартныеВычетыНарастающимИтогом = new Guid("7c963c93-3c28-0546-4bae-58a6c381f54f");//Стандартные вычеты применяются нарастающим итогом в течение налогового периода
		public static readonly Guid СтандартныеВычетыВПределахМесячногоДохода = new Guid("4557a1b9-5e89-c837-43a3-ef69263c2861");//Стандартные вычеты применяются в пределах месячного дохода налогоплательщика
		public static ОсобенностиИсчисленияНДФЛ Получить(this ОсобенностиИсчисленияНДФЛ Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ОсобенностиИсчисленияНДФЛ Получить(this ОсобенностиИсчисленияНДФЛ Значение, Guid Ссылка)
		{
			if(Ссылка == СтандартныеВычетыНарастающимИтогом)
			{
				return ОсобенностиИсчисленияНДФЛ.СтандартныеВычетыНарастающимИтогом;
			}
			else if(Ссылка == СтандартныеВычетыВПределахМесячногоДохода)
			{
				return ОсобенностиИсчисленияНДФЛ.СтандартныеВычетыВПределахМесячногоДохода;
			}
			return ОсобенностиИсчисленияНДФЛ.ПустаяСсылка;
		}
		public static byte[] Ключ(this ОсобенностиИсчисленияНДФЛ Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ОсобенностиИсчисленияНДФЛ Значение)
		{
			switch (Значение)
			{
				case ОсобенностиИсчисленияНДФЛ.СтандартныеВычетыНарастающимИтогом: return СтандартныеВычетыНарастающимИтогом;
				case ОсобенностиИсчисленияНДФЛ.СтандартныеВычетыВПределахМесячногоДохода: return СтандартныеВычетыВПределахМесячногоДохода;
			}
			return Guid.Empty;
		}
	}
}