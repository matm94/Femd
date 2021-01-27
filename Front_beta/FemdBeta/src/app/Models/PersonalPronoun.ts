export class PersonalPronoun
{
  Translation: string;
  FirstPerson: string;
  SecondPerson: string;
  ThirdPerson: string;
  FirstPersonPlural: string;
  SecondPersonPlural: string;
  ThirdPersonPlural: string;
  Formal: string;
  PhotoPath: string;

  constructor(translation: string, firstPerson: string, secondPerson: string, thirdPerson: string,
              firstPersonPlural: string, secondPersonPlural: string, thirdPersonPlural: string,
              formal: string)
  {
    this.Translation = translation;
    this.FirstPerson = firstPerson;
    this.SecondPerson = secondPerson;
    this.ThirdPerson = thirdPerson;
    this.FirstPersonPlural = firstPersonPlural;
    this.SecondPersonPlural = secondPersonPlural;
    this.ThirdPersonPlural = thirdPersonPlural;
    this.Formal = formal;
  }
}
