CREATE TABLE course (
    subject_id UUID REFERENCES subject(subject_id) NOT NULL,
    teacher_id UUID REFERENCES teacher(teacher_id) NOT NULL,
    feedback Feedback[]
)