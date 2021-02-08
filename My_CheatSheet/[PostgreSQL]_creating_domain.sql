--we can create domain that will work as our custom 
--validation type
--domain is just an Alias for existing type

CREATE DOMAIN Rating SMALLINT CHECK (VALUE > 0 AND VALUE <=5)

--Then while creating type:
CREATE TYPE Feedback AS (
    student_id UUID,
    rating Rating,
    feedback TEXT
)