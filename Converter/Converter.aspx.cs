using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace Converter
{
    public partial class Converter : Page
    {
        private IDictionary<string, string> _currencies;

        protected void Page_Load(object sender, EventArgs e)
        {
            _currencies = Global.Currencies;
            if (!IsPostBack)
            {
                var keys = _currencies.Keys.ToList();
                SourceCurrency.DataSource = keys;
                SourceCurrency.DataBind();
                DestinationCurrency.DataSource = keys;
                DestinationCurrency.DataBind();
                SourceCourse.Text = _currencies[SourceCurrency.SelectedValue];
                SourceCourse.DataBind();
                DestinationCourse.Text = _currencies[DestinationCurrency.SelectedValue];
                DestinationCourse.DataBind();
            }
        }

        protected void SourceCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            SourceCourse.Text = _currencies[SourceCurrency.SelectedValue];
            SourceCourse.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal sourceCourse, destinationCourse, sum;
            if (!decimal.TryParse(SourceCourse.Text, out sourceCourse))
            {
                ResultLabel.Text = "Неверный ввод курса исходной валюты";
                return;
            }

            if (!decimal.TryParse(DestinationCourse.Text, out destinationCourse))
            {
                ResultLabel.Text = "Неверный ввод курса целевой валюты";
                return;
            }

            if (!decimal.TryParse(Sum.Text, out sum))
            {
                ResultLabel.Text = "Неверный ввод суммы";
                return;
            }

            decimal result = sourceCourse * sum / destinationCourse;
            ResultLabel.Text = String.Format(
                "{0} {1} = {2} {3}",
                Math.Round(sum, 4),
                SourceCurrency.SelectedValue,
                Math.Round(result, 4),
                DestinationCurrency.SelectedValue);

        }

        protected void DestinationCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            DestinationCourse.Text = _currencies[DestinationCurrency.SelectedValue];
            DestinationCourse.DataBind();
        }
    }
}