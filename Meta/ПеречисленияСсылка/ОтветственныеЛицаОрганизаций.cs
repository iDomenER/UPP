﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Регл)
	///</summary>
	[DataContract]
	public enum ОтветственныеЛицаОрганизаций
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"e2751737-7387-4677-b349-b72df0541171\", \"Представление\":\"Руководитель\"}")]
		Руководитель = 0,
		[EnumMember(Value = "{\"Ссылка\":\"54f1db0d-9f3a-4e28-9189-cf187221efcc\", \"Представление\":\"ГлавныйБухгалтер\"}")]
		ГлавныйБухгалтер = 1,//Главный бухгалтер
		[EnumMember(Value = "{\"Ссылка\":\"e015fef2-f48b-4395-aa40-fec279a90907\", \"Представление\":\"РуководительКадровойСлужбы\"}")]
		РуководительКадровойСлужбы = 2,//Руководитель кадровой службы
		[EnumMember(Value = "{\"Ссылка\":\"4b17e0dd-babd-41af-b848-16be473f158d\", \"Представление\":\"Кассир\"}")]
		Кассир = 3,
		[EnumMember(Value = "{\"Ссылка\":\"fb7b7583-f5cf-4d4a-affd-4ba26b1077a1\", \"Представление\":\"ОтветственныйЗаНалоговыеРегистры\"}")]
		ОтветственныйЗаНалоговыеРегистры = 4,//Ответственный за налоговые регистры
		[EnumMember(Value = "{\"Ссылка\":\"9504b2f6-efe9-455c-bca6-9d73915743b0\", \"Представление\":\"УполномоченныйПредставитель\"}")]
		УполномоченныйПредставитель = 5,//Уполномоченный представитель
		[EnumMember(Value = "{\"Ссылка\":\"f660e403-f39a-46c1-933d-25d33b669265\", \"Представление\":\"ИндивидуальныйПредприниматель\"}")]
		ИндивидуальныйПредприниматель = 6,//Индивидуальный предприниматель
		[EnumMember(Value = "{\"Ссылка\":\"987cac1a-fac7-42c3-b213-0ff7f76110cf\", \"Представление\":\"Исполнитель\"}")]
		Исполнитель = 7,
	}
	public static partial class ОтветственныеЛицаОрганизаций_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Руководитель = new Guid("2db749b3-54f0-7111-4677-7387e2751737");
		public static readonly Guid ГлавныйБухгалтер = new Guid("18cf8991-2172-ccef-4e28-9f3a54f1db0d");//Главный бухгалтер
		public static readonly Guid РуководительКадровойСлужбы = new Guid("c2fe40aa-a979-0709-4395-f48be015fef2");//Руководитель кадровой службы
		public static readonly Guid Кассир = new Guid("be1648b8-3f47-8d15-41af-babd4b17e0dd");
		public static readonly Guid ОтветственныйЗаНалоговыеРегистры = new Guid("a24bfdaf-106b-a177-4d4a-f5cffb7b7583");//Ответственный за налоговые регистры
		public static readonly Guid УполномоченныйПредставитель = new Guid("739da6bc-5791-b043-455c-efe99504b2f6");//Уполномоченный представитель
		public static readonly Guid ИндивидуальныйПредприниматель = new Guid("d3253d93-663b-6592-46c1-f39af660e403");//Индивидуальный предприниматель
		public static readonly Guid Исполнитель = new Guid("f70f13b2-61f7-cf10-42c3-fac7987cac1a");
		public static ОтветственныеЛицаОрганизаций Получить(this ОтветственныеЛицаОрганизаций Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ОтветственныеЛицаОрганизаций Получить(this ОтветственныеЛицаОрганизаций Значение, Guid Ссылка)
		{
			if(Ссылка == Руководитель)
			{
				return ОтветственныеЛицаОрганизаций.Руководитель;
			}
			else if(Ссылка == ГлавныйБухгалтер)
			{
				return ОтветственныеЛицаОрганизаций.ГлавныйБухгалтер;
			}
			else if(Ссылка == РуководительКадровойСлужбы)
			{
				return ОтветственныеЛицаОрганизаций.РуководительКадровойСлужбы;
			}
			else if(Ссылка == Кассир)
			{
				return ОтветственныеЛицаОрганизаций.Кассир;
			}
			else if(Ссылка == ОтветственныйЗаНалоговыеРегистры)
			{
				return ОтветственныеЛицаОрганизаций.ОтветственныйЗаНалоговыеРегистры;
			}
			else if(Ссылка == УполномоченныйПредставитель)
			{
				return ОтветственныеЛицаОрганизаций.УполномоченныйПредставитель;
			}
			else if(Ссылка == ИндивидуальныйПредприниматель)
			{
				return ОтветственныеЛицаОрганизаций.ИндивидуальныйПредприниматель;
			}
			else if(Ссылка == Исполнитель)
			{
				return ОтветственныеЛицаОрганизаций.Исполнитель;
			}
			return ОтветственныеЛицаОрганизаций.ПустаяСсылка;
		}
		public static byte[] Ключ(this ОтветственныеЛицаОрганизаций Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ОтветственныеЛицаОрганизаций Значение)
		{
			switch (Значение)
			{
				case ОтветственныеЛицаОрганизаций.Руководитель: return Руководитель;
				case ОтветственныеЛицаОрганизаций.ГлавныйБухгалтер: return ГлавныйБухгалтер;
				case ОтветственныеЛицаОрганизаций.РуководительКадровойСлужбы: return РуководительКадровойСлужбы;
				case ОтветственныеЛицаОрганизаций.Кассир: return Кассир;
				case ОтветственныеЛицаОрганизаций.ОтветственныйЗаНалоговыеРегистры: return ОтветственныйЗаНалоговыеРегистры;
				case ОтветственныеЛицаОрганизаций.УполномоченныйПредставитель: return УполномоченныйПредставитель;
				case ОтветственныеЛицаОрганизаций.ИндивидуальныйПредприниматель: return ИндивидуальныйПредприниматель;
				case ОтветственныеЛицаОрганизаций.Исполнитель: return Исполнитель;
			}
			return Guid.Empty;
		}
	}
}