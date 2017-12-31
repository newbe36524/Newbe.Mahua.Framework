using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Threading.Tasks;

namespace Newbe.Mahua.Samples.Sqlite.Services.Impl
{
    /// <inheritdoc />
    /// <summary>
    /// 通过数据库实现好友信息存储
    /// </summary>
    internal class FriendMessageStore : IFriendMessageStore
    {
        private readonly IDbHelper _dbHelper;

        public FriendMessageStore(IDbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public async Task<int> GetCountAsync()
        {
            using (var conn = await _dbHelper.CreateDbConnectionAsync())
            {
                var count = await conn.ExecuteScalarAsync<int>("select count(1) from MSG");
                return count;
            }
        }

        public async Task InsertAsync(InsertFriendMessageInput input)
        {
            using (var conn = await _dbHelper.CreateDbConnectionAsync())
            {
                await conn.InsertAsync(new MessageEntity
                {
                    Id = Guid.NewGuid().ToString(),
                    Message = input.Message,
                    Qq = input.Qq,
                    ReceivedTime = input.ReceivedTime.ToString("s")
                });
            }
        }

        [Table("MSG")]
        public class MessageEntity
        {
            [Key] public string Id { get; set; }
            public string Qq { get; set; }
            public string Message { get; set; }
            public string ReceivedTime { get; set; }
        }
    }
}
