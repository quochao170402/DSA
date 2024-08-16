/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        int length = prices.Length;
        if (length == 1)
        {
            return 0;
        }

        int buyDay = 0;
        int sellDay = 1;

        int maxProfit = 0;

        while (sellDay < length)
        {
            if (prices[sellDay] < prices[buyDay])
            {
                buyDay++;
                if (buyDay == sellDay)
                {
                    sellDay++;
                }
                continue;
            }

            var profit = prices[sellDay] - prices[buyDay];

            if (maxProfit < profit)
            {
                maxProfit = profit;
                sellDay++;
                continue;
            }

            sellDay++;

        }
        return maxProfit;
    }

    public void Solution()
    {
        int[] prices = [2, 1, 2, 1, 0, 1, 2];
        System.Console.WriteLine(MaxProfit(prices));
        System.Console.WriteLine(Improve(prices));
    }

    public int Improve(int[] prices)
    {
        int minPrice = prices[0];
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            var price = prices[i];
            if (price < minPrice)
            {
                minPrice = price;
            }

            var profit = price - minPrice;

            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }
        return maxProfit;
    }
}
// @lc code=end

