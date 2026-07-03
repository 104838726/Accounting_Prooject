using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSVAccounting_Project
{
    public static class DbHelper
    {
        //建立資料表
        public static void InitDb()
        {
            using (var conn = new SqliteConnection("Data Source=accounting.db"))
            {
                conn.Open();
                string sql = """
                        CREATE TABLE if not exists "item" (
                    	"id"	INTEGER,
                    	"date"	TEXT NOT NULL,
                    	"note"	TEXT,
                    	"amount"	REAL NOT NULL DEFAULT 1,
                    	"category"	TEXT NOT NULL DEFAULT '食',
                    	"isincome"	INTEGER NOT NULL DEFAULT 0,
                    	PRIMARY KEY("id" AUTOINCREMENT)
                    );
                    """;
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static List<Item> GetAllItems()
        {
            var result = new List<Item>();
            using (var conn = new SqliteConnection("Data Source=accounting.db"))
            {
                conn.Open();
                string sql = " select * from item";


                using (var cmd = new SqliteCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new Item();
                            item.Id = Convert.ToInt32(reader["id"]);
                            item.Date = Convert.ToDateTime(reader["date"]);
                            item.Note = reader["note"].ToString()!;
                            item.CategoryType = (Category)Enum.Parse(typeof(Category), reader["category"].ToString()!);
                            item.IsIncome = Convert.ToInt32(reader["isincome"]) == 1;
                            result.Add(item);
                        }
                    }
                }


            }

            return result;
        }

        //新增資料
        public static void InsertItem(Item item)
        {
            using (var conn = new SqliteConnection("Data Source=accounting.db"))
            {
                conn.Open();
                string sql = """
                    insert into item(date,note,amount,category,isincome) values
                    (@date,@note,@amount,@category,@isincome);
                    """;
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@date", item.Date.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@note", item.Note);
                    cmd.Parameters.AddWithValue("@amount", (double)item.Amount);
                    cmd.Parameters.AddWithValue("@category", item.CategoryType.ToString());
                    cmd.Parameters.AddWithValue("@isincome", item.IsIncome);

                    cmd.ExecuteNonQuery();
                }

            }

        }
        //刪除
        public static void DeleteItem(Item item)
        {
            using (var conn = new SqliteConnection("Data Source=accounting.db"))
            {
                conn.Open();
                string sql = "delete from item where id = @id";


                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", item.Id);


                    cmd.ExecuteNonQuery();
                }

            }
        }

        //刪除全部
        public static void DeleteAllItem(Item item)
        {
            using (var conn = new SqliteConnection("Data Source=accounting.db"))
            {
                conn.Open();
                string sql = "delete from item";


                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }

            }
        }


        //修改

        public static void UpdateItem(Item item)
        {
            using (var conn = new SqliteConnection("Data Source=accounting.db"))
            {
                conn.Open();
                string sql = """
                    update item set
                    date=@date,
                    note=@note,
                    amount=@amount,
                    category=@category
                    isincome=@isincome
                    where id=@id
                    """;
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@date", item.Date.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@note", item.Note);
                    cmd.Parameters.AddWithValue("@amount", (double)item.Amount);
                    cmd.Parameters.AddWithValue("@category", item.CategoryType.ToString());
                    cmd.Parameters.AddWithValue("@isincome", item.IsIncome);
                    cmd.Parameters.AddWithValue("@id", item.Id);

                    cmd.ExecuteNonQuery();
                }

            }

        }

    }
}