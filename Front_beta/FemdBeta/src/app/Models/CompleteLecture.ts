import { PersonalPronoun } from './PersonalPronoun';
import { PartsOfSpeech } from '../Models/PartsOfSpeech';
import { Verb } from './Verb';

export class CompleteLecture
{
  Id: string;
  Name: string;
  LectureNumber: number;
  Desription: string;
  Adjectives: Array<PartsOfSpeech>;
  Adverbs: Array<PartsOfSpeech>;
  PersonalPronuns: Array<PersonalPronoun>;
  Nouns: Array<PartsOfSpeech>;
  Sentences: Array<PartsOfSpeech>;
  Verbs: Array<Verb>;

  constructor(id: string, name: string, lectureNumber: number, description: string, adjectives: Array<PartsOfSpeech>)
  {
      this.Id = id;
      this.Name = name;
      this.LectureNumber = lectureNumber;
      this.Desription = description;
      this.Adjectives = adjectives;

  }
}
