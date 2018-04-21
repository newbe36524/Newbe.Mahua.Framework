namespace Newbe.Mahua.Messages.Steps
{
    public interface INormalMessageStep<out T> :
        ITextStep<T>,
        IImageStep<T>,
        IFaceStep<T>,
        IBFaceStep<T>,
        ISFaceStep<T>,
        IEmojiStep<T>
        where T : IMessageBuildStep
    {
    }
}
