class Comment {
    constructor(name, text) {
        this.name = name;
        this.created = 'секунду назад';
        this.text = text;
        this.likes = 0;
        this.dislikes = 0;
    }
}

function AppCommentModel() {
    let self = this;
    self.comments = ko.observableArray([]);
    self.answerBoxVisibe = ko.observable(false);

    self.addComment = function (postId, parentCommentId = null) {
        const commentBoxId = '#comment-box';
        var answerCommentBoxId = `#${parentCommentId}-comment-box`;
        const text = parentCommentId === null ? $(commentBoxId).val() : $(answerCommentBoxId).val();
        $(commentBoxId).val('');
        $(answerCommentBoxId).val('');

        $.ajax({
            url: '/comment/addcomment',
            type: 'POST',
            contentType: "application/json",
            data: JSON.stringify({
                Text: text,
                PostId: postId,
                ParentCommentId: parentCommentId
            }),
            success: (data) => {
                document.location.reload(true);
            },
            error: (error) => {
                console.log(error);
            }
        });
    };

    self.displayAnswerCommentBox = function (commentId, parentCommentId, isVisible, userName) {
        const answerId = parentCommentId ? parentCommentId : commentId;
        $('.asnwer-comment-box').hide();
        $('.asnwer-comment-box').val('');
        $(`#${parentCommentId}-comment-box`).val('');

        const answerComment = $('#' + answerId + '-asnwer-comment-box');
        if (isVisible) {
            if (parentCommentId) {
                $(`#${parentCommentId}-comment-box`).val('@' + userName + ', ');
            }
            answerComment.show();
        }
        else {
            answerComment.hide();
        }
    };

    self.setReaction = function (commentId, parentCommentId, currentReaction) {
        $.ajax({
            url: '/comment/setcommentreaction',
            type: 'POST',
            contentType: "application/json",
            data: JSON.stringify({
                ParentCommentId: parentCommentId,
                CommentId: commentId,
                Liked: currentReaction
            }),
            success: (data) => {
                $(`#${commentId}-likes .comment-likes`).text(data.likes);
                $(`#${commentId}-dislikes .comment-dislikes`).text(data.dislikes);
                $(`#${commentId}-likes`).removeClass();
                $(`#${commentId}-dislikes`).removeClass();

                if (data.reaction === 1) {
                    $(`#${commentId}-likes`).addClass('noReaction');
                    $(`#${commentId}-dislikes`).addClass('noReaction');
                }
                else if (data.reaction === 2) {
                    $(`#${commentId}-likes`).addClass("liked");
                    $(`#${commentId}-dislikes`).addClass('noReaction');
                }
                else if (data.reaction === 3) {
                    $(`#${commentId}-dislikes`).addClass("disliked");
                    $(`#${commentId}-likes`).addClass('noReaction');
                }
            },
            error: (error) => {
                if (error.status === 403) {
                    $('#authorizeModal').modal('show');
                }
            }
        });
    };
}

ko.applyBindings(new AppCommentModel(), document.getElementById('post-comments-form'));

