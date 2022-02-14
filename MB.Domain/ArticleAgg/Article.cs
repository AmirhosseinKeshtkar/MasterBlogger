﻿using System;
using MB.Domain.ArticleCategoryAgg;

namespace MB.Domain.ArticleAgg {
    public class Article {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string Image { get; private set; }
        public string Content { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; set; }
        public long ArticleCategoryId { get; set; }
        public ArticleCategory ArticleCategory { get; set; }

        protected Article() {
        }

        public Article(string title, string shortDescription, string image, string content, long articleCategoryId) {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            ArticleCategoryId = articleCategoryId;
            CreationDate = DateTime.Now;
            IsDeleted = false;
        }

        public void EditArticle(string title, string shortDescription, string image, string content, long articleCategoryId) {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            ArticleCategoryId = articleCategoryId;
        }

        public void Remove() {
            IsDeleted=true;
        }

        public void Activate() {
            IsDeleted=false;
        }
    }
}
