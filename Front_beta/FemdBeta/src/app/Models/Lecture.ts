export class Lecture
{
  Id: string;
  LectureName: string;
  LectureNumber: number;
  Desription: string;

  constructor(id: string, lectureName: string, lectureNumber: number, description: string)
  {
    this.Id = id;
    this.LectureName = lectureName;
    this.LectureNumber = lectureNumber;
    this.Desription = description;
  }
}
