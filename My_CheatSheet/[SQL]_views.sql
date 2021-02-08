Create VIEW view_name AS query_ref;

--views acts like tables you can query them

--editing
CREATE or REPLACE <view_name> AS query;

--renaming
ALTER VIEW <view_name> RENAME TO <view_name>;

--deleting view
DROP VIEW [IF EXISTS ] <view_name>;