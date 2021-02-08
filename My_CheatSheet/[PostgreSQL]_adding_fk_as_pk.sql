CREATE TABLE enrollment (
    student_id UUID REFERENCES student(student_id),
    course_id UUID REFERENCES course(course_id),
    enrollment_date DATE NOT NULL,
    CONSTRAINT pk_enrollment PRIMARY KEY (course_id, student_id)
)