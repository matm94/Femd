export class PartsOfSpeech
{
  Translation: string;
  Content: string;
  PhotoPath: string;

  constructor(translation: string, content: string, photoPath: string)
  {
    this.Translation = translation;
    this.Content = content;
    this.PhotoPath = photoPath;
  }
}
