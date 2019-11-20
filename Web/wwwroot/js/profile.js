function ProfileCommentsViewModel() {
    let self = this;
    self.comments = ko.observableArray([]);

    self.getPostUrl = function (postUrl, commentId) {
        return `/home/post?url=${postUrl}#${commentId}`;
    }

    self.load = function () {
        $.ajax({
            url: '/account/getprofilecomments',
            type: 'GET',
            success: (comments) => {
                console.log(comments);
                for (let comment of comments) {
                    self.comments.push(comment);
                }
            },
            error: (error) => {

            }
        });
    };

    self.delete = function (comment) {
        if (confirm("Вы действительно хотите удалить комментарий?")) {
            const commentId = comment.commentId;
            const isTopLevel = comment.parentCommentId === null;
            $.ajax({
                url: '/account/deletecomment',
                type: 'POST',
                contentType: "application/json",
                data: JSON.stringify({
                    CommentId: commentId,
                    TopLevel: isTopLevel,
                    PostUrl: comment.postUrl
                }),
                success: (comments) => {
                    const comment = self.comments().find(p => p.commentId === commentId);
                    self.comments.remove(comment);
                },
                error: (error) => {

                }
            });
        }
    };

    self.load();
}

ko.applyBindings(new ProfileCommentsViewModel(), document.getElementById("profile-comments"));
