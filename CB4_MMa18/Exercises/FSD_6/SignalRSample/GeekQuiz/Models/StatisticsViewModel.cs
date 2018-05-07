// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

namespace GeekQuiz.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class StatisticsViewModel
    {
        [DisplayName("Total")]
        public int TotalAnswers { get; set; }

        [DisplayName("Correct")]
        public int CorrectAnswers { get; set; }

        [DisplayName("Incorrect")]
        public int IncorrectAnswers { get; set; }

        [DisplayName("Correct p/user")]
        [DisplayFormat(DataFormatString = "{0:F}")]
        public float CorrectAnswersAverage { get; set; }

        [DisplayName("Incorrect p/user")]
        [DisplayFormat(DataFormatString = "{0:F}")]
        public float IncorrectAnswersAverage { get; set; }

        [DisplayName("Total p/user")]
        [DisplayFormat(DataFormatString = "{0:F}")]
        public float TotalAnswersAverage { get; set; }
    }
}