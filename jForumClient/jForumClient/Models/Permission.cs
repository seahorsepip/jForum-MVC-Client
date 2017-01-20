using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jForumClient.Models
{
    public enum Permission
    {
        NONE,
        CREATE_FORUM,
        READ_FORUM,
        UPDATE_FORUM,
        DELETE_FORUM,
        CREATE_SECTION,
        READ_SECTION,
        UPDATE_SECTION,
        DELETE_SECTION,
        CREATE_TOPIC,
        READ_TOPIC,
        UPDATE_TOPIC,
        DELETE_TOPIC,
        UPDATE_ALL_TOPIC,
        DELETE_ALL_TOPIC,
        CREATE_POST,
        READ_POST,
        UPDATE_POST,
        DELETE_POST,
        UPDATE_ALL_POSTS,
        DELETE_ALL_POSTS,
        CREATE_GROUP,
        READ_GROUP,
        UPDATE_GROUP,
        DELETE_GROUP,
        DELETE_ALL_USERS,
        ADD_USER_TO_GROUP,
        REMOVE_USER_FROM_GROUP,
        CREATE_GROUP_PERMISSION,
        READ_GROUP_PERMISSION,
        DELETE_GROUP_PERMISSION
    }
}