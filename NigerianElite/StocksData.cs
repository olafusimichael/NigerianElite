namespace NigerianElite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StocksData")]
    public partial class StocksData
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string Company { get; set; }

        public double? Year { get; set; }

        public double? Revenues { get; set; }

        [Column("Cost of goods sold")]
        public double? Cost_of_goods_sold { get; set; }

        [Column("Gross Profit")]
        public double? Gross_Profit { get; set; }

        [Column("Selling general & administrative expenses")]
        public double? Selling_general___administrative_expenses { get; set; }

        [Column("Operating Profit")]
        public double? Operating_Profit { get; set; }

        [Column("Interest Income net")]
        public double? Interest_Income_net { get; set; }

        [Column("Earnings before Income taxes")]
        public double? Earnings_before_Income_taxes { get; set; }

        [Column("Income tax expense")]
        public double? Income_tax_expense { get; set; }

        [Column("Net Profit")]
        public double? Net_Profit { get; set; }

        [Column("Cash and cash equivalents")]
        public double? Cash_and_cash_equivalents { get; set; }

        [Column("Account receivable")]
        public double? Account_receivable { get; set; }

        public double? Inventories { get; set; }

        [Column("Prepaid expenses and other")]
        public double? Prepaid_expenses_and_other { get; set; }

        [Column("Current Deferred taxes")]
        public double? Current_Deferred_taxes { get; set; }

        [Column("Total Current Assets")]
        public double? Total_Current_Assets { get; set; }

        [Column("Property Plant and Equipment net")]
        public double? Property_Plant_and_Equipment_net { get; set; }

        [Column("Intangible assets")]
        public double? Intangible_assets { get; set; }

        [Column("Other Long term Assets")]
        public double? Other_Long_term_Assets { get; set; }

        [Column("Total Assets")]
        public double? Total_Assets { get; set; }

        [Column("Bank lines of credit")]
        public double? Bank_lines_of_credit { get; set; }

        [Column("Trade accounts payable")]
        public double? Trade_accounts_payable { get; set; }

        [Column("Accrued Current liabilities")]
        public double? Accrued_Current_liabilities { get; set; }

        [Column("Total Current Liabilities")]
        public double? Total_Current_Liabilities { get; set; }

        [Column("Long-term Borrowings")]
        public double? Long_term_Borrowings { get; set; }

        [Column("Long-term Deferred taxes")]
        public double? Long_term_Deferred_taxes { get; set; }

        [Column("Long term Commitments")]
        public double? Long_term_Commitments { get; set; }

        [Column("Other Long-term Liabilities")]
        public double? Other_Long_term_Liabilities { get; set; }

        [Column("Total Liabilities")]
        public double? Total_Liabilities { get; set; }

        [Column("Preferred Stock")]
        public double? Preferred_Stock { get; set; }

        [Column("Class A common stock")]
        public double? Class_A_common_stock { get; set; }

        [Column("Revaluation Reserve")]
        public double? Revaluation_Reserve { get; set; }

        [Column("Additional paid-in capital")]
        public double? Additional_paid_in_capital { get; set; }

        [Column("Treasury stock")]
        public double? Treasury_stock { get; set; }

        [Column("Retained earnings")]
        public double? Retained_earnings { get; set; }

        [Column("Foreign currency translation")]
        public double? Foreign_currency_translation { get; set; }

        [Column("Non-controlling Interest")]
        public double? Non_controlling_Interest { get; set; }

        [Column("Total Liabilities And S# E#")]
        public double? Total_Liabilities_And_S__E_ { get; set; }

        [Column("Net Income")]
        public double? Net_Income { get; set; }

        [Column("(Increase)/Decrease in Accounts receivable")]
        public double? C_Increase__Decrease_in_Accounts_receivable { get; set; }

        [Column("(Increase)/Decrease in Inventory")]
        public double? C_Increase__Decrease_in_Inventory { get; set; }

        [Column("(Increase)/Decrease in Prepaid expenses and other")]
        public double? C_Increase__Decrease_in_Prepaid_expenses_and_other { get; set; }

        [Column("(Increase)/Decrease in Deferred taxes")]
        public double? C_Increase__Decrease_in_Deferred_taxes { get; set; }

        [Column("Increase/(Decrease) in Bank lines of credit")]
        public double? Increase__Decrease__in_Bank_lines_of_credit { get; set; }

        [Column("Increase/(Decrease) in Trade accounts payable")]
        public double? Increase__Decrease__in_Trade_accounts_payable { get; set; }

        [Column("Increase/(Decrease) in Accrued liabilities")]
        public double? Increase__Decrease__in_Accrued_liabilities { get; set; }

        [Column("Cash Flows from Operating Activities")]
        public double? Cash_Flows_from_Operating_Activities { get; set; }

        [Column("Increase/(Decrease) in Operating Cash Flow")]
        public double? Increase__Decrease__in_Operating_Cash_Flow { get; set; }

        [Column("Cash Flows from Investing Activities")]
        public double? Cash_Flows_from_Investing_Activities { get; set; }

        [Column("Increase/(Decrease) In Investing Cash Flow")]
        public double? Increase__Decrease__In_Investing_Cash_Flow { get; set; }

        [Column("Cash Flows from Financing Activities")]
        public double? Cash_Flows_from_Financing_Activities { get; set; }

        [Column("Increase/(Decrease) in Financing Cash Flow")]
        public double? Increase__Decrease__in_Financing_Cash_Flow { get; set; }

        [Column("Net Cash Flows")]
        public double? Net_Cash_Flows { get; set; }

        [Column("Beginning Cash Balance")]
        public double? Beginning_Cash_Balance { get; set; }

        public double? Forex { get; set; }

        [Column("Ending Cash Balance")]
        public double? Ending_Cash_Balance { get; set; }

        [Column("Revenue Growth")]
        public double? Revenue_Growth { get; set; }

        [Column("Cost of goods sold as a % of Rev#")]
        public double? Cost_of_goods_sold_as_a___of_Rev_ { get; set; }

        [Column("SG&A as a % of Rev#")]
        public double? SG_A_as_a___of_Rev_ { get; set; }

        [Column("Operating Profit Margin")]
        public double? Operating_Profit_Margin { get; set; }

        public double? ROIC { get; set; }

        [Column("Cash Flow as a % of Rev")]
        public double? Cash_Flow_as_a___of_Rev { get; set; }

        public double? ROA { get; set; }

        public double? ROE { get; set; }

        [Column("Interest Incomenet as a % of Rev#")]
        public double? Interest_Incomenet_as_a___of_Rev_ { get; set; }

        [Column("Income tax expense as a % of Rev#")]
        public double? Income_tax_expense_as_a___of_Rev_ { get; set; }

        [Column("Accounts receivable as a % of Rev#")]
        public double? Accounts_receivable_as_a___of_Rev_ { get; set; }

        [Column("Inventories as a % of Rev#")]
        public double? Inventories_as_a___of_Rev_ { get; set; }

        [Column("Prepaid expenses and other as a % of Rev#")]
        public double? Prepaid_expenses_and_other_as_a___of_Rev_ { get; set; }

        [Column("Deferred taxes as a % of Rev#")]
        public double? Deferred_taxes_as_a___of_Rev_ { get; set; }

        [Column("Bank lines of credit as a % of Rev#")]
        public double? Bank_lines_of_credit_as_a___of_Rev_ { get; set; }

        [Column("Trade accounts payable as a % of Rev#")]
        public double? Trade_accounts_payable_as_a___of_Rev_ { get; set; }

        [Column("Accrued liabilities as a % of Rev#")]
        public double? Accrued_liabilities_as_a___of_Rev_ { get; set; }
    }
}
