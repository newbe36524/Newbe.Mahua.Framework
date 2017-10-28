using FluentAssertions;
using MessagePack;
using Newbe.Mahua.CQP.Commands;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Runtime.Serialization;
using Xunit;
using Xunit.Abstractions;

namespace Newbe.Mahua.LibTests
{
    public class SerializerTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public SerializerTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Test()
        {
            var bytes = (byte[])typeof(MessagePackSerializer).GetMethods().First(x => x.Name == nameof(MessagePackSerializer.Serialize) && x.GetParameters().Length == 1)
                .MakeGenericMethod(typeof(InitializeCommand)).Invoke(null, new object[]
                {
                    new InitializeCommand
                    {
                        AuthCode = 55
                    }
                });
            var re = MessagePackSerializer.Deserialize<InitializeCommand>(bytes);
            re.AuthCode.Should().Be(55);
            _testOutputHelper.WriteLine(re.AuthCode.ToString());
        }

        [Fact]
        public void UseJsonNet()
        {
            var newGuid = Guid.NewGuid();
            for (int i = 0; i < 1000000; i++)
            {
                var student = new Student
                {
                    Age = null,
                    Guid = newGuid,
                    IsMale = true,
                    Name =
                        "student1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111",
                    Status = Status.Disable
                };
                var json = JsonConvert.SerializeObject(student);
                student = JsonConvert.DeserializeObject<Student>(json);
            }
        }


        [Fact]
        public void UseMessagePack()
        {
            var newGuid = Guid.NewGuid();
            for (int i = 0; i < 1000000; i++)
            {
                var student = new Student
                {
                    Age = null,
                    Guid = newGuid,
                    IsMale = true,
                    Name =
                        "student1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111",
                    Status = Status.Disable
                };
                var json = MessagePackSerializer.Serialize(student);
                student = MessagePackSerializer.Deserialize<Student>(json);
            }
        }
    }

    [DataContract]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int? Age { get; set; }

        [DataMember]
        public Guid Guid { get; set; }

        [DataMember]
        public bool IsMale { get; set; }

        [DataMember]
        public Status Status { get; set; }
    }

    public enum Status
    {
        Enable,
        Disable,
    }
}
