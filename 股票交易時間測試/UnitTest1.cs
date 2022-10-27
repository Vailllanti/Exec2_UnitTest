using 判斷是否在股票交易營業日以及時間內;

namespace 股票交易時間測試
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase("2022 / 10 / 27 09:10", true)]
		[TestCase("2022 / 10 / 26 13:10", true)]

		public void 交易日內交易時間內(DateTime datetime,bool expected)
		{
			var obj = new TaiwainStockUtility();
			bool answer = obj.IsTradingTime(datetime);

			Assert.AreEqual(answer,expected);
		}

		[TestCase("2022 / 10 / 27 08:10", false)]
		[TestCase("2022 / 10 / 27 17:10", false)]

		public void 交易日內交易時間外(DateTime datetime, bool expected)
		{
			var obj = new TaiwainStockUtility();
			bool answer = obj.IsTradingTime(datetime);

			Assert.AreEqual(answer, expected);
		}

		[TestCase("2022 / 10 / 29 09:10", false)]
		[TestCase("2022 / 10 / 29 11:10", false)]

		public void 交易日外交易時間內(DateTime datetime, bool expected)
		{
			var obj = new TaiwainStockUtility();
			bool answer = obj.IsTradingTime(datetime);

			Assert.AreEqual(answer, expected);
		}

		[TestCase("2022 / 10 / 29 17:10", false)]
		[TestCase("2022 / 10 / 29 01:10", false)]

		public void 交易日外交易時間外(DateTime datetime, bool expected)
		{
			var obj = new TaiwainStockUtility();
			bool answer = obj.IsTradingTime(datetime);

			Assert.AreEqual(answer, expected);
		}
	}
}