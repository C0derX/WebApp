using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Common.Enums
{
    public enum AdPosition
    {
        [Display(Name ="Logo aside")]
        logo_aside=1,
        [Display(Name = "Below menue bar")]
        below_menu_bar,
        [Display(Name = "Home page bottom")]
        home_page_bottom,
        [Display(Name = "Home page right sidebar")]
        home_page_right_sidebar,
        [Display(Name = "News category right sidebar")]
        news_category_right_sidebar,
        [Display(Name = "news category top")]
        news_category_top,
        [Display(Name = "News category bottom")]
        news_category_bottom,
        [Display(Name = "News detail below title")]
        news_detail_below_title,
        [Display(Name = "News detail above title")]
        news_detail_above_title,
        [Display(Name = "News detail above description")]
        news_detail_above_description,
        [Display(Name = "News detail between news")]
        news_detail_between_news,
        [Display(Name = "News detail bottom")]
        news_detail_bottom,
        [Display(Name = "Home page between news")]
        home_page_between_news,

    }
}
