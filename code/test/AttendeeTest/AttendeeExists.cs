using System;
using Xunit;
using Xunit.Extensions;
using Attendees;

namespace AttendeeTest
{
    public class AttendeeTest
    {
        [Fact]
        public void AttendeeExistsReturnTrue()
        {
            Attendee attendee = new Attendee();
            bool doesExist = attendee.AddAttendee("doesnotexist");
            Assert.False(doesExist, "The attendee does not exist");
        }
        ,
 "follow-redirects": {
   "version": "1.14.1",
   "resolved": "https://registry.npmjs.org/follow-redirects/-/follow-redirects-1.14.1.tgz",
   "integrity": "sha512-HWqDgT7ZEkqRzBvc2s64vSZ/hfOceEol3ac/7tKwzuvEyWx3/4UegXh5oBOIotkGsObyk3xznnSRVADBgWSQVg=="
 }
    }
}
