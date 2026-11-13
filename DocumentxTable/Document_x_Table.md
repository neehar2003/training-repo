#Document vs Table

##Table (relational DB)
1.Stores information in rows & coloumns
2.Schema is strict & fixed
3.DB can be bloated with lot of null values, which makes DB look large, but actual info stored in DB is not that large enough
4.Related data is split across multiple tables and linked with foreign keys (joins)
5.Eg: MySQL

```
Users - Table
Id | Name    | Phone
1  | Neehar  | -
2  | Bhargav | 1234
```

##Document (non relational DB)
1.Stores information like key-value pairs or documents
2.Data stored as JSON like documents (BSON-binary)
3.Scheme is flexible, each document can have diff fields.
4.Can store nested documents & arrays
5.Eg: MongoDB

``
Document(MongoDB)
{"name": "Neehar"}
{"name": "Bhargav","phone":"1234"}
``