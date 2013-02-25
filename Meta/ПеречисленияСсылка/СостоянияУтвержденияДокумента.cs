﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum СостоянияУтвержденияДокумента
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"31388d6c-833f-4446-8a71-f8006c5ba1d4\", \"Представление\":\"УтвержденПолностьюПроведен\"}")]
		УтвержденПолностьюПроведен = 0,//Документ утвержден полностью, проведен
		[EnumMember(Value = "{\"Ссылка\":\"3a5eafe5-f7cd-4f12-8158-e522c3857fa6\", \"Представление\":\"УтвержденЧастичноПроведен\"}")]
		УтвержденЧастичноПроведен = 1,//Документ утвержден частично, проведен
		[EnumMember(Value = "{\"Ссылка\":\"161b4ef9-1efb-4087-ae53-1c90a640efad\", \"Представление\":\"НеУтвержденПроведен\"}")]
		НеУтвержденПроведен = 2,//Документ не утвержден, проведен
		[EnumMember(Value = "{\"Ссылка\":\"ab5b1e78-f901-4a61-b0b9-e3da481f751e\", \"Представление\":\"УтвержденПолностьюНеПроведен\"}")]
		УтвержденПолностьюНеПроведен = 3,//Документ утвержден полностью, не проведен
		[EnumMember(Value = "{\"Ссылка\":\"613184ac-43e5-40fe-aa71-a100af413164\", \"Представление\":\"УтвержденЧастичноНеПроведен\"}")]
		УтвержденЧастичноНеПроведен = 4,//Документ утвержден частично, не проведен
		[EnumMember(Value = "{\"Ссылка\":\"46011458-1027-4505-a90c-8230973fa9ac\", \"Представление\":\"НеУтвержденНеПроведен\"}")]
		НеУтвержденНеПроведен = 5,//Документ не утвержден, не проведен
	}
	public static partial class СостоянияУтвержденияДокумента_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid УтвержденПолностьюПроведен = new Guid("00f8718a-5b6c-d4a1-4446-833f31388d6c");//Документ утвержден полностью, проведен
		public static readonly Guid УтвержденЧастичноПроведен = new Guid("22e55881-85c3-a67f-4f12-f7cd3a5eafe5");//Документ утвержден частично, проведен
		public static readonly Guid НеУтвержденПроведен = new Guid("901c53ae-40a6-adef-4087-1efb161b4ef9");//Документ не утвержден, проведен
		public static readonly Guid УтвержденПолностьюНеПроведен = new Guid("dae3b9b0-1f48-1e75-4a61-f901ab5b1e78");//Документ утвержден полностью, не проведен
		public static readonly Guid УтвержденЧастичноНеПроведен = new Guid("00a171aa-41af-6431-40fe-43e5613184ac");//Документ утвержден частично, не проведен
		public static readonly Guid НеУтвержденНеПроведен = new Guid("30820ca9-3f97-aca9-4505-102746011458");//Документ не утвержден, не проведен
		public static СостоянияУтвержденияДокумента Получить(this СостоянияУтвержденияДокумента Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СостоянияУтвержденияДокумента Получить(this СостоянияУтвержденияДокумента Значение, Guid Ссылка)
		{
			if(Ссылка == УтвержденПолностьюПроведен)
			{
				return СостоянияУтвержденияДокумента.УтвержденПолностьюПроведен;
			}
			else if(Ссылка == УтвержденЧастичноПроведен)
			{
				return СостоянияУтвержденияДокумента.УтвержденЧастичноПроведен;
			}
			else if(Ссылка == НеУтвержденПроведен)
			{
				return СостоянияУтвержденияДокумента.НеУтвержденПроведен;
			}
			else if(Ссылка == УтвержденПолностьюНеПроведен)
			{
				return СостоянияУтвержденияДокумента.УтвержденПолностьюНеПроведен;
			}
			else if(Ссылка == УтвержденЧастичноНеПроведен)
			{
				return СостоянияУтвержденияДокумента.УтвержденЧастичноНеПроведен;
			}
			else if(Ссылка == НеУтвержденНеПроведен)
			{
				return СостоянияУтвержденияДокумента.НеУтвержденНеПроведен;
			}
			return СостоянияУтвержденияДокумента.ПустаяСсылка;
		}
		public static byte[] Ключ(this СостоянияУтвержденияДокумента Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СостоянияУтвержденияДокумента Значение)
		{
			switch (Значение)
			{
				case СостоянияУтвержденияДокумента.УтвержденПолностьюПроведен: return УтвержденПолностьюПроведен;
				case СостоянияУтвержденияДокумента.УтвержденЧастичноПроведен: return УтвержденЧастичноПроведен;
				case СостоянияУтвержденияДокумента.НеУтвержденПроведен: return НеУтвержденПроведен;
				case СостоянияУтвержденияДокумента.УтвержденПолностьюНеПроведен: return УтвержденПолностьюНеПроведен;
				case СостоянияУтвержденияДокумента.УтвержденЧастичноНеПроведен: return УтвержденЧастичноНеПроведен;
				case СостоянияУтвержденияДокумента.НеУтвержденНеПроведен: return НеУтвержденНеПроведен;
			}
			return Guid.Empty;
		}
	}
}