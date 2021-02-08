UPDATE course
SET feedback = array_append(
    feedback,
    ROW(
        'uuid',
        5,
        'My opinion'
    )::feedback
)
WHERE course_id = 'course id';