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

}
