import { Directive, HostListener, Input, ElementRef, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appDate]'
})
export class DateDirective {

  @Input()
  private date: Date;
  private paragrapf;

  constructor(private el: ElementRef, private renderer: Renderer2) {

    this.paragrapf = this.renderer.createElement('p');
   }

  @HostListener('mouseenter')
  mouseenter(EventDate: Event){

    this.paragrapf.innerHTML = this.date.toLocaleDateString();
    this.renderer.appendChild(this.el.nativeElement, this.paragrapf);
  }

  @HostListener('mouseleave')
  mouseleave(EventDate: Event){

    this.renderer.removeChild(this.el.nativeElement, this.paragrapf);
  }
}
