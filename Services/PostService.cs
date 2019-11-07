using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using DataAccess;
using Domain;
using MongoDB.Driver.Linq;

namespace Services
{
    public class PostService
    {
        private PostRepositoryRead _postRepositoryRead { get; } = new PostRepositoryRead();
        private CommentRepository _commentRepository { get; } = new CommentRepository();


        private DatabaseContext _context = new DatabaseContext();

        public async Task<IEnumerable<PostPreviewDto>> GetPostPreviews(int skip)
        {
            var posts = await _postRepositoryRead.GetPostPreviews(skip, 9);
            return posts.Select(x => new PostPreviewDto(x.title, x.url, 1, 2, 3, 4));
        }

        public async Task<IEnumerable<PostPreviewDto>> GetRandomPostPreviews(PostType type, int number)
        {
            var posts = await _postRepositoryRead.GetRandomPostPreviews((int)type, number);
            return posts.Select(x => new PostPreviewDto(x.title, x.url, 0, 0, 0, 0));
        }

        public async Task<PostDto> GetPost(string url)
        {
            var post = await _postRepositoryRead.GetPost(url);
            var comments = await _commentRepository.GetComments(post.InternalId.ToString());

            return new PostDto(post.InternalId.ToString(), post.title, post.url, post.text, comments);
        }
    }
}
